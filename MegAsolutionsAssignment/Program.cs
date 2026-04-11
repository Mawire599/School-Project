using System;
using System.Windows.Forms;

namespace MegAsolutionsAssignment
{
    internal static class ProgramBase1
    {
    }

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
