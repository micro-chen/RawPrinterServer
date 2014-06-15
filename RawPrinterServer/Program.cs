using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;

namespace IDINCU.RawPrinterServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            RawPrinterServerService printerService = new RawPrinterServerService();
            printerService.OnDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new RawPrinterServerService() 
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
