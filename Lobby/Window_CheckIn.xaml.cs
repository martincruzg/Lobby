using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Window_CheckIn.xaml
    /// </summary>
    public partial class Window_CheckIn : Window
    {
        public Window_CheckIn()
        {
            InitializeComponent();

            this.ResizeMode = ResizeMode.CanMinimize;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {

            //TESTING THE HOTEL ARRAY IS SAVING THE ////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*string MESSAGE = string.Empty;
            for (int i = 0; i < HotelFeatures.Floors; i++)
            {
                for (int j = 0; j < HotelFeatures.RoomPerFloor; j++)
                {
                    MESSAGE += HotelFeatures.HotelRooms[i, j].Name + HotelFeatures.HotelRooms[i, j].NumGuest + HotelFeatures.HotelRooms[i, j].CheckIn;
                }
            }
            MessageBox.Show(MESSAGE, "Booking error", MessageBoxButton.OK);*/
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            bool NameFlag = CheckName();
            bool NumGuestsFlag = CheckNumGuests();
            bool DataOutFlag = CheckDataOut();

            if (NameFlag && NumGuestsFlag && DataOutFlag)
            {
                int ChosenRoom = ChooseRoom();
                SaveChackIn(ChosenRoom);
                /*MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();*/
            }
            else
            {
                ErrorCheckInMessage(NameFlag, NumGuestsFlag, DataOutFlag);
            }

        }
        
        private int ChooseRoom()
        {
            for (int i = 0; i < HotelFeatures.Floors; i++)
            {
                for (int j = 0; j < HotelFeatures.RoomPerFloor; j++)
                {
                    if (!HotelFeatures.HotelRooms[i, j].RoomStatus)
                    {
                        return i * 10 + j;
                    }
                }
            }
            return 0;
        }

        private void SaveChackIn(int chosenRoom)
        {
            Guest guest = new Guest();

            guest.Name = NameInput.Text;
            guest.NumGuests = int.Parse(NumGuestsInput.Text);
            guest.CheckOut = DataCheckOutInput.Text;
            DateTime todayDate = DateTime.Today;
            var todayDateString = todayDate.ToString("MM/dd/yyyy");
            guest.CheckIn = todayDateString;
            guest.RoomStatus = true;

            HotelFeatures.HotelRooms[chosenRoom / 10, chosenRoom % 10] = guest;
            MessageBox.Show("Your reservation has been successfully saved.", "Booking successful", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void ErrorCheckInMessage(bool nameFlag, bool numGuestsFlag, bool dataOutFlag)
        {
            string message = string.Empty;
            if (!nameFlag) { message += "- The name is invalid (it can only contain letters).\n"; }
            if (!numGuestsFlag) { message += "- Number of guests must be indicated.\n"; }
            if (!dataOutFlag) { message += "- The checkout date must be indicated.\n"; }
            MessageBox.Show(message, "Booking error", MessageBoxButton.OK);
        }

        private bool CheckName()
        {
            if (!string.IsNullOrEmpty(NameInput.Text) && Regex.IsMatch(NameInput.Text, "^[a-zA-Z ]+$"))
            {
                return true;
            }
            return false;
        }

        private bool CheckNumGuests()
        {
            if (string.IsNullOrEmpty(NumGuestsInput.Text))
            {
                return false;
            }
            return true;
        }

        private bool CheckDataOut()
        {
            if (string.IsNullOrEmpty(DataCheckOutInput.Text))
            {
                return false;
            }
            return true;
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
