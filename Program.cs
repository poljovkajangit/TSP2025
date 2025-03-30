using TSP2025.Reports;

namespace TSP2025
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmParent());
            //Application.Run(new frmScottPloting());
        }
    }
}