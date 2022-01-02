using System;
using System.Windows.Forms;

namespace ImageFilters
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            form.Size = new System.Drawing.Size(935, 550);
            Application.Run(form);
        }
    }
}