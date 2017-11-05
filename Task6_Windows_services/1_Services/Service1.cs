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

namespace _1_Services
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Evgeny\VS Projects\C-sharp-B\Task6_Windows_services\1_Services\test.txt",     // Name of opening file
                FileMode.OpenOrCreate,  // Waht will happen
                FileAccess.Write);      // Accessing
            StreamWriter sr = new StreamWriter(fs);     // Creating stream to write
            DateTime d1 = DateTime.Now;     // Getting time
            sr.WriteLine("Service1 has been started at " + d1 + ToString());   // Writing in file
            sr.Flush();     //Flushing buffer

            EventLog.WriteEntry("Service1 started ");
        }

        protected override void OnStop()
        {
            FileStream fs = new FileStream(@"C:\Users\Evgeny\VS Projects\C-sharp-B\Task6_Windows_services\1_Services\test.txt",
                FileMode.OpenOrCreate,
                FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            DateTime d1 = DateTime.Now;
            sr.WriteLine("Service1 has been stopped at " + d1.ToString());
            sr.Flush();
        }
    }
}
