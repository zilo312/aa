using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace Wrox.ProCSharp.WinServices
{
    public partial class QuoteService : ServiceBase
    {
        private QuoteServer quoteServer;

        public QuoteService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            quoteServer = new QuoteServer(
                  @"c:\ProCSharp\WindowsServices\quotes.txt", 5678);
            quoteServer.Start();

        }

        protected override void OnStop()
        {
            quoteServer.Stop();
        }

        protected override void OnPause()
        {
            quoteServer.Suspend();
        }
        protected override void OnContinue()
        {
            quoteServer.Resume();
        }
        protected override void OnShutdown()
        {
            OnStop();
        }
        public const int commandRefresh = 128;
        protected override void OnCustomCommand(int command)
        {
            switch (command)
            {
                case commandRefresh:
                    quoteServer.RefreshQuotes();
                    break;
                default:
                    break;
            }
        }

        protected override bool OnPowerEvent(PowerBroadcastStatus powerStatus)
        {
            switch (powerStatus)
            {
                case PowerBroadcastStatus.PowerStatusChange:

                    break;
                case PowerBroadcastStatus.BatteryLow:
                    break;
        }
            return base.OnPowerEvent(powerStatus);
        }

    }
}
