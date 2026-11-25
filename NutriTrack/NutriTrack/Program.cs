using System;
using System.Windows.Forms;

namespace NutriTrack
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Navigator.Start(new LoginForm());
            Application.Run();
        }
    }
}
