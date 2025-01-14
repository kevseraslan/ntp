using System;
using System.Windows.Forms;

namespace ReviseMee
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreenForm()); // SplashScreen formunu başlat

        }

    }
}
