using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace AutoZapService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            #if (!DEBUG)

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new AutoZap() 
			};
            ServiceBase.Run(ServicesToRun);

            #else

                AutoZap service = new AutoZap();
                // Chamada do seu método para Debug.
                service.Run();
                // Coloque sempre um breakpoint para o ponto de parada do seu código.
                System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

            #endif



        }
    }
}
