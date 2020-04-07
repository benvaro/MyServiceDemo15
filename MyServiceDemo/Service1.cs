using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceDemo
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Logger("Service started");
        }

        protected override void OnStop()
        {
            Logger("Service stopped");
        }

        private void Logger(string message)
        {
            try
            {
                message += "\t\t" + DateTime.Now.ToLongTimeString();
                File.AppendAllText("svclog.txt", message);
            }
            catch (Exception ex)
            {
                File.AppendAllText("Error.txt", "\n" + ex.Message);
            }
        }
    }
}
