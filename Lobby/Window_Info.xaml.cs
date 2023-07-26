using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lobby
{
    /// <summary>
    /// Interaction logic for Window_Info.xaml
    /// </summary>
    public partial class Window_Info : Window
    {
        public Window_Info()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.CanMinimize;
        }

        private void Status_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
