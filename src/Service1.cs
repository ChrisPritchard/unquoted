using System.Diagnostics;
using System.ServiceProcess;

namespace unquoted
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // change to whatever you want to invoke. args can be passed as further args to the below func
            Process.Start(@"c:\windows\temp\c.exe");
        }
    }
}
