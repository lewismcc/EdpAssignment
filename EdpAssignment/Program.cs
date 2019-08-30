using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDPLibrary.Banking;
using EDPLibrary.Database;
using EDPLibrary.Password;


namespace EdpAssignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            MainWindow mainForm = MainWindow.GetInstance();
            LoginScreen login = new LoginScreen();
            mainForm.ContentPanel.Controls.Add(login);
            Application.Run(mainForm);
        }
    }
}
