using Rebroadcaster.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Rebroadcaster
{
    class Rebroadcaster : Application
    {
        [STAThread]
        public static void Main(String[] args)
        {
            var app = new Rebroadcaster();
            app.MainWindow = new MainWindowView();
            app.MainWindow.Show();
            app.Run();
        }
    }
}
