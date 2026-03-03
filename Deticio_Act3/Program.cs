using System;
using System.Windows.Forms;

namespace Deticio_Act3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Deticio_Act3.EnrollmentForm());
        }
    }
}