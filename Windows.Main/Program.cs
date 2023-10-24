using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Main.Controllers;
using Windows.Main.View;
using Windows.Main.View.DefaultSettingsView;

namespace Windows.Main
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
            var view = new MainForm();
            MainFormController controller = new MainFormController(view);
            Application.Run(controller.View);
          
        }
    }
}
