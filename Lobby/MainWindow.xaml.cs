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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lobby
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.CanMinimize;
        }

        private void Check_In_Click(object sender, RoutedEventArgs e)
        {
            Window_CheckIn window_CheckIn = new Window_CheckIn();
            window_CheckIn.Show();
        }

        private void Check_Out_Click(object sender, RoutedEventArgs e)
        {
            Window_CheckOut window_CheckOut = new Window_CheckOut();
            window_CheckOut.Show();
        }

        private void Rooms_Click(object sender, RoutedEventArgs e)
        {
            Window_Info window_Info = new Window_Info();
            window_Info.Show();
        }

        private void Prueba_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
