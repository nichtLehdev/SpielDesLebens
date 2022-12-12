// @author events.json: Joel Dag, Viktoria Gönnheimer, Maximilian Koch
// @author actions.json: Maximilian Koch
// Default starting point of the application.

using System;
using System.Windows.Forms;

namespace SpielDesLebens
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            // For Debugging only !!!
#if DEBUG
            Data.SetFilePathsDebug();
            // Application.Run(new UiDebug());
#endif
            Application.Run(new UiMenu());
        }
    }
}