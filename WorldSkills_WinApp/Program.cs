using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills_WinApp
{
    internal static class Program
    {
        private static ApplicationContext Context { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Context = new ApplicationContext(new FormAuthorization());
            Application.Run(Context);
        }

        public static void OpenForm(Form newForm)
        {
            Form currentForm = Context.MainForm;

            Context.MainForm = newForm;
            Context.MainForm.Show();

            currentForm.Close();
        }
    }
}
