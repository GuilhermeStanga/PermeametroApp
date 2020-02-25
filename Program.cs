using PermeametroApp.Servicos;
using PermeametroApp.Servicos.Interfaces;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace PermeametroApp
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            //Application.Run(new Principal());
            Application.Run( container.GetInstance<Principal>() );
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<IServico, Servico>(Lifestyle.Singleton);
            //container.Register<IUserContext, WinFormsUserContext>();
            container.Register<Principal>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
