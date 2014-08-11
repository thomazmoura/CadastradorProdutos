using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SysShop.Forms
{
    static class Program
    {
        /// <summary> O ponto de entrada principal da aplicação </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
        }
    }
}
