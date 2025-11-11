using System;
using System.Security.Cryptography.X509Certificates;
using RevVise1.Forms;
namespace RevVise1
{
    internal static class Program
    {
        
        public static bool isAuthenticated;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RevDB db = new RevDB();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new AuthForm());
            AuthForm auth = new AuthForm();
            auth.ShowDialog();
            if (isAuthenticated)
            {
                MainForm main = new MainForm();
                main.ShowDialog();
            }
        }
    }
}