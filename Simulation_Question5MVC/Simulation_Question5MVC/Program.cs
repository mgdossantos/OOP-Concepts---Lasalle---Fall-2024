using System;
using System.Windows.Forms;

namespace Simulation_Question5MVC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ProductView view = new ProductView();
            ProductController controller = new ProductController(view);
            Application.Run(view);
        }
    }
}
