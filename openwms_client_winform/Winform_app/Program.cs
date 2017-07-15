using open.winform.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Winform_app
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mw = new MainWindow();
           
            //maindock.dp = mw.;
            Application.Run(mw);
            
        }
    }
}
