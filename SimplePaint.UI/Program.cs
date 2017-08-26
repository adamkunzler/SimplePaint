using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Add handler to handle the exception raised by main threads
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            // Add handler to handle the exception raised by additional threads
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaintForm());

            // Stop the application and all the threads in suspended state.
            Environment.Exit(-1);
        }

        #region Exception Handling

        // All exceptions thrown by the main thread are handled over this method
        static void Application_ThreadException (object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowExceptionDetails(e.Exception);
        }

        // All exceptions thrown by additional threads are handled in this method
        static void CurrentDomain_UnhandledException (object sender, UnhandledExceptionEventArgs e)
        {
            ShowExceptionDetails(e.ExceptionObject as Exception);

            // Suspend the current thread for now to stop the exception from throwing.
            Thread.CurrentThread.Suspend();
        }

        static void ShowExceptionDetails(Exception Ex)
        {
            // Do logging of exception details
            MessageBox.Show(Ex.Message, Ex.TargetSite.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Exception Handling
    }
}
