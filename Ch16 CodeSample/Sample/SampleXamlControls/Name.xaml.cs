using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleXamlControls
{
  /// <summary>
  /// Interaction logic for Name.xaml
  /// </summary>

  public partial class Name : System.Windows.Controls.UserControl
  {
    public Name()
    {
      InitializeComponent();
    }

    public string FullName
    {
      get
      {
        return String.Concat(firstNameText.Text, " ", lastNameText.Text);
      }
    }
  }
}