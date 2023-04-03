using System.ServiceProcess;

namespace unquoted
{
    internal static class Program
    {
        static void Main()
        {
            var ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
