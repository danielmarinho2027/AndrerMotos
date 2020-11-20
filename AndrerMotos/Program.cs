using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;

namespace AndrerMotos
{
    static class Program
    {
        public static Container container;

        public static void Bootstrap()
        {
            container = new Container();


            container.Verify();
        }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new Frm_Estoque());
        }
    }
}
