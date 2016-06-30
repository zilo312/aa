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
using System.Windows.Shapes;
using System.ServiceProcess;


namespace ServiceControl
{

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class ServiceControlWindow : System.Windows.Window
    {
        public ServiceControlWindow()
        {
            InitializeComponent();

            buttonStart.Click += OnServiceCommand;
            buttonStop.Click += OnServiceCommand;
            buttonPause.Click += OnServiceCommand;
            buttonContinue.Click += OnServiceCommand;
            buttonRefresh.Click += OnRefresh;
            buttonExit.Click += OnExit;

            RefreshServiceList();

        }

        void OnRefresh(object sender, RoutedEventArgs e)
        {
            RefreshServiceList();
        }

        void OnServiceCommand(object sender, RoutedEventArgs e)
        {
            Cursor oldCursor = this.Cursor;
            this.Cursor = Cursors.Wait;
            ServiceControllerInfo si = listBoxServices.SelectedItem as ServiceControllerInfo;

            if (sender == buttonStart)
            {
                si.Controller.Start();
                si.Controller.WaitForStatus(ServiceControllerStatus.Running);
            }
            else if (sender == buttonStop)
            {
                si.Controller.Stop();
                si.Controller.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            else if (sender == buttonPause)
            {
                si.Controller.Pause();
                si.Controller.WaitForStatus(ServiceControllerStatus.Paused);
            }
            else if (sender == buttonContinue)
            {
                si.Controller.Continue();
                si.Controller.WaitForStatus(ServiceControllerStatus.Running);
            }

            int index = listBoxServices.SelectedIndex;
            RefreshServiceList();
            listBoxServices.SelectedIndex = index;

            this.Cursor = oldCursor;
        }


        void OnExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected void RefreshServiceList()
        {
            ServiceController[] services = ServiceController.GetServices();

            Array.Sort<ServiceController>(services,
                delegate(ServiceController s1, ServiceController s2)
                {
                    return s1.DisplayName.CompareTo(s2.DisplayName);
                });
            ServiceControllerInfo[] serviceInfo =
                Array.ConvertAll<ServiceController, ServiceControllerInfo>(
                services,
                delegate(ServiceController controller)
                {
                    return new ServiceControllerInfo(controller);
                });

            this.DataContext = serviceInfo;
        }
    }
}