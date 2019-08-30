using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdpAssignment
{
    public partial class MainWindow : Form
    {
        private static MainWindow mainWindow = null;


        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The GetInstance method creates a mainwindow object
        /// if it doesnt exist already 
        /// otherwise it will return the previously created mainwindow
        /// </summary>
        /// <returns></returns>
        public static MainWindow GetInstance()
        {
            if(mainWindow != null)
            {
                return mainWindow;
            }
            mainWindow = new MainWindow();
            return mainWindow;
        }

    }
}
