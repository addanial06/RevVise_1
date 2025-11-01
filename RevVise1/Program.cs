using System;
using RevVise1.Forms;
namespace RevVise1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new AuthForm());
            AuthForm auth = new AuthForm();
            auth.ShowDialog();

        }
    }
}