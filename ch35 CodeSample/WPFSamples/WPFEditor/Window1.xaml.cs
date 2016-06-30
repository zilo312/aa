using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace Wrox.ProCSharp.WPF
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class WPFEditorWindow : Window
   {
      private string fileName;
      private readonly string defaultFileName;
      private const string appName = "WPF Editor";
      private bool isChanged = false;


      public WPFEditorWindow()
      {
         defaultFileName = System.IO.Path.Combine(
            Environment.GetFolderPath(
               Environment.SpecialFolder.MyDocuments),
            @"untitled.txt");
         InitializeComponent();
         NewFile();

      }

      private void NewFileExecuted(object sender, ExecutedRoutedEventArgs e)
      {
         NewFile();
      }

      private void NewFile()
      {
         textContent.Clear();
         fileName = defaultFileName;
         SetTitle();
         isChanged = false;
      }

      private void SetTitle()
      {
         Title = String.Format("{0} {1}", System.IO.Path.GetFileName(fileName), appName);
      }

      private void OpenFileExecuted(object sender, ExecutedRoutedEventArgs e)
      {
         try
         {
            OpenFileDialog dlg = new OpenFileDialog();
            bool? dialogResult = dlg.ShowDialog();
            if (dialogResult == true)
            {
               fileName = dlg.FileName;
               SetTitle();
               textContent.Text = File.ReadAllText(fileName);
            }
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Error WPF Editor",
                MessageBoxButton.OK, MessageBoxImage.Error);
         }
      }

      private void SaveFile()
      {
         try
         {
            File.WriteAllText(fileName, textContent.Text);
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Error WPF Editor",
                  MessageBoxButton.OK, MessageBoxImage.Error);
         }
      }

      private void SaveFileAs()
      {
         SaveFileDialog dlg = new SaveFileDialog();
         bool? dialogResult = dlg.ShowDialog();
         if (dialogResult == true)
         {
            fileName = dlg.FileName;
            SaveFile();
         }
      }

      private void SaveFileExecuted(object sender, ExecutedRoutedEventArgs e)
      {
         if (fileName == defaultFileName)
         {
            SaveFileAs();
         }
         else
         {
            SaveFile();
         }
      }

      private void SaveAsFileExecuted(object sender, ExecutedRoutedEventArgs e)
      {
         SaveFileAs();
      }

      private void SaveFileCanExecute(object sender, CanExecuteRoutedEventArgs e)
      {
         if (isChanged)
         {
            e.CanExecute = true;
         }
         else
         {
            e.CanExecute = false;
         }
      }

      private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
      {
         isChanged = true;

      }

   }
}
