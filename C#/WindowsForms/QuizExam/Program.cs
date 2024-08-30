using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizExam
{
    internal static class Program
    {
        public static Form MainForm { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new Form();
            // Создайте и откройте форму авторизации
            while(MainForm != null)
            {
                Authorization authorization = new Authorization();
                Application.Run(authorization);
            }
        }
    }
}
