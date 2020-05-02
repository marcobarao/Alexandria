using System;
using System.Windows.Forms;
using Alexandria.Screens;

namespace Alexandria
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Resolver.Wire(Bindings.Create());
            Application.Run(Resolver.Resolve<Lobby>());
        }
    }
}
