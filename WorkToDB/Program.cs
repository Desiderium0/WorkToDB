using System;
using System.Windows.Forms;
using WorkToDB.Forms;

namespace WorkToDB
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GreetingForm());
        }
    }
}
