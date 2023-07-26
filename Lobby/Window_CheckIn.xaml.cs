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
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            Guest guest = new Guest();

            bool NameFlag = CheckName();
            bool NumGuestsFlag = CheckNumGuests();
            bool DataOutFlag = CheckDataOut();

            if (CheckInSave(NameFlag, NumGuestsFlag, DataOutFlag))
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }

        }

        private static bool CheckInSave(bool nameFlag, bool numGuestsFlag, bool dataOutFlag)
        {
            if (nameFlag && numGuestsFlag && dataOutFlag)
            {
                MessageBox.Show("Your reservation has been successfully completed, we hope you enjoy it.", "Success booking", MessageBoxButton.OK);
                return true;
            }
            MessageBox.Show("Bad input", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            return false;
        }

        private bool CheckDataOut()
        {
            if (string.IsNullOrEmpty(NameInput.Text) && Regex.IsMatch(NameInput.Text, @"^[a-zA-Z\s]+$"))
            {
                return false;
            }
            return true;
        }

        private bool CheckNumGuests()
        {
            if (string.IsNullOrEmpty(NameInput.Text))
            {
                return false;
            }
            return true;
        }

        private bool CheckName()
        {
            if (string.IsNullOrEmpty(NameInput.Text))
            {/*
                MessageBox.Show("Gracias por tu retroalimentación", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                MessageBox.Show("Gracias por tu retroalimentación2", "Error", MessageBoxButton.OK, MessageBoxImage.Information);*/
                return false;
            }/*
            NameInput.Text += DateCheckOutInput.Text;*/
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
