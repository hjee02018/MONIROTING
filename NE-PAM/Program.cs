using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace NE_PAM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bCreateNew = false;
			String strValue = "MONITORING";
			Mutex dup = new Mutex(true, strValue, out bCreateNew);

            if (bCreateNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());

                dup.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("프로그램이 이미 실행중입니다.", "MONIROTING V1.2");
            }
        }
    }
}
