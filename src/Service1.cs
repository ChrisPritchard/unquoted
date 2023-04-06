using System;
using System.Diagnostics;
using System.IO;
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
            var to_run_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "torun.txt");
            if (!File.Exists(to_run_file))
                return;
                
            var input = File.ReadAllLines(to_run_file);
            if (input.Length == 0) {
                return;
            }
            
            var command = input[0].Trim();
            var file_end = command.IndexOf(" ");

            try {
                if (file_end == -1) {
                    Process.Start(command);
                } else {
                    Process.Start(command.Substring(0, file_end), command.Substring(file_end + 1));
                }
            } catch (Exception ex) {
                throw new Exception($"Failed to invoke {command}", ex);
            }
        }
    }
}
