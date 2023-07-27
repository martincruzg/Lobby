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
            if (!string.IsNullOrEmpty(FloorInput.Text) && !string.IsNullOrEmpty(RoomInput.Text))
            {
                if (HotelFeatures.HotelRooms[int.Parse(FloorInput.Text) - 1, int.Parse(RoomInput.Text) - 1].RoomStatus)
                {
                    InfoTextBox.Text = GetInfo();
                }
                else
                {
                    InfoTextBox.Text = "Free room";
                }
            }
            else
            {
                InfoTextBox.Text = "Choose a room";
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
        private string GetInfo()
        {
            var infoMessage = new string(string.Empty);
            infoMessage += "Guest: " + HotelFeatures.HotelRooms[int.Parse(FloorInput.Text) - 1, int.Parse(RoomInput.Text) - 1].Name + "\n";

            infoMessage += "Number of guests: " + HotelFeatures.HotelRooms[int.Parse(FloorInput.Text) - 1, int.Parse(RoomInput.Text) - 1].NumGuest + "\n";

            infoMessage += "Check-In date: " + HotelFeatures.HotelRooms[int.Parse(FloorInput.Text) - 1, int.Parse(RoomInput.Text) - 1].CheckIn + "\n";

            infoMessage += "Check-Out date: " + HotelFeatures.HotelRooms[int.Parse(FloorInput.Text) - 1, int.Parse(RoomInput.Text) - 1].CheckOut + "\n";

            return infoMessage;
        }
    }
}
