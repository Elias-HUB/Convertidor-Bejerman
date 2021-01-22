using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bejerman
{   

    static class Program
    {
        static public Singleton singleton = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            singleton = Singleton.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Configuracion());
        }
    }
}
