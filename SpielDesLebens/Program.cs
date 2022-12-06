// @author events.json: Joel Dag, Viktoria Gönnheimer, Maximilian Koch
// @author actions.json: Maximilian Koch

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
            Application.Run(new UiMenu());
        }
    }
}