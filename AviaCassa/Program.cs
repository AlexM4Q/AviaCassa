using System;
using System.Windows.Forms;

namespace AviaCassa {

    internal static class Program {

        /// <summary>
        /// Точка входа для приложения
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

    }

}