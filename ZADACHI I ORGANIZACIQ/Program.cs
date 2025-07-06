using System.Windows.Forms;
using ZADACHI_I_ORGANIZACIQ;

namespace TaskTracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var mgr = new TaskManager();
            mgr.Load();

            ApplicationConfiguration.Initialize();               
            Application.ApplicationExit += (_, __) => mgr.Save(); 
            Application.Run(new MainForm(mgr));                   
        }
    }
}