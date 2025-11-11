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

            while (true)
            {
                using (AuthForm auth = new AuthForm())
                {

                    var result = auth.ShowDialog();

                    if (!isAuthenticated || result != DialogResult.OK)
                        break;

                    using (MainForm main = new MainForm())
                    {
                        main.ShowDialog();
                    }

                    if (isAuthenticated)
                        break;

                    isAuthenticated = false;
                }
            }
        }
    }
}