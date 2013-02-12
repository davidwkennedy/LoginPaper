using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

// DELETE: Testing Edit Mode In GitHub

namespace loginswitcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new loginswitcher() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}
