using Microsoft.Extensions.DependencyInjection;
using NeedsMoreJPEG_core;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreJPEG_UI
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogManager.ReconfigExistingLoggers();
            LogManager.GetCurrentClassLogger().Debug("Init main");
            ServiceProvider = ConfigureServices();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(ServiceProvider));
        }

        static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IMoreJPEG, Core>();
            return services.BuildServiceProvider();
        }
    }
}
