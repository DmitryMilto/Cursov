using System;
using System.Windows.Forms;
using CurceRPVS.View;

namespace CurceRPVS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Load());
            //Application.Run(new Form1());
        }
    }
}
