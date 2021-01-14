using System;
using System.Windows.Forms;
using SimpleInjector;
using SimpleInjector.Diagnostics;

namespace Tax_Service
{
    static class Program
    {
        public static readonly Container container;

        static Program()
        {
            container = new Container();

            container.Register<ITaxCalculator, TaxCalculator>(Lifestyle.Singleton);
            container.Register<ITaxService, TaxService>(Lifestyle.Singleton);

            container.Verify();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
