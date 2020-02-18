using System;
using System.Collections.Generic;
using System.IO;
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

namespace DogAdoptionPart2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //IEnumerable<string> lines = File.ReadLines("C:/Users/dblon/source/repos/DogAdoptionPart2/DogInformation.txt").ToArray();
        string[] dogInfo = File.ReadLines("C:/Users/dblon/source/repos/DogAdoptionPart2/DogInformation.txt").ToArray();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DogBella_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bella.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(10);
            breedTextBox.Text = (string)dogInfo.GetValue(20);
            weightTextBox.Text = (string)dogInfo.GetValue(30);
            shotsTextBox.Text = (string)dogInfo.GetValue(40);
            availableTextBox.Text = (string)dogInfo.GetValue(50);
        }

        private void DogCharlie_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/charlie.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(1);
            bdayTextBox.Text = (string)dogInfo.GetValue(11);
            breedTextBox.Text = (string)dogInfo.GetValue(21);
            weightTextBox.Text = (string)dogInfo.GetValue(31);
            shotsTextBox.Text = (string)dogInfo.GetValue(41);
            availableTextBox.Text = (string)dogInfo.GetValue(51);
        }

        private void DogLuna_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/luna.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(2);
            bdayTextBox.Text = (string)dogInfo.GetValue(12);
            breedTextBox.Text = (string)dogInfo.GetValue(22);
            weightTextBox.Text = (string)dogInfo.GetValue(32);
            shotsTextBox.Text = (string)dogInfo.GetValue(42);
            availableTextBox.Text = (string)dogInfo.GetValue(52);
        }

        private void DogLucy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/lucy.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(3);
            bdayTextBox.Text = (string)dogInfo.GetValue(13);
            breedTextBox.Text = (string)dogInfo.GetValue(23);
            weightTextBox.Text = (string)dogInfo.GetValue(33);
            shotsTextBox.Text = (string)dogInfo.GetValue(43);
            availableTextBox.Text = (string)dogInfo.GetValue(53);
        }

        private void DogMax_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/max.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(4);
            bdayTextBox.Text = (string)dogInfo.GetValue(14);
            breedTextBox.Text = (string)dogInfo.GetValue(24);
            weightTextBox.Text = (string)dogInfo.GetValue(34);
            shotsTextBox.Text = (string)dogInfo.GetValue(44);
            availableTextBox.Text = (string)dogInfo.GetValue(54);
        }

        private void DogBailey_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bailey.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(5);
            bdayTextBox.Text = (string)dogInfo.GetValue(15);
            breedTextBox.Text = (string)dogInfo.GetValue(25);
            weightTextBox.Text = (string)dogInfo.GetValue(35);
            shotsTextBox.Text = (string)dogInfo.GetValue(45);
            availableTextBox.Text = (string)dogInfo.GetValue(55);
        }

        private void DogCooper_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/cooper.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(6);
            bdayTextBox.Text = (string)dogInfo.GetValue(16);
            breedTextBox.Text = (string)dogInfo.GetValue(26);
            weightTextBox.Text = (string)dogInfo.GetValue(36);
            shotsTextBox.Text = (string)dogInfo.GetValue(46);
            availableTextBox.Text = (string)dogInfo.GetValue(56);
        }

        private void DogDaisy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/daisy.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(7);
            bdayTextBox.Text = (string)dogInfo.GetValue(17);
            breedTextBox.Text = (string)dogInfo.GetValue(27);
            weightTextBox.Text = (string)dogInfo.GetValue(37);
            shotsTextBox.Text = (string)dogInfo.GetValue(47);
            availableTextBox.Text = (string)dogInfo.GetValue(57);
        }

        private void DogHexi_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/hexi.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(8);
            bdayTextBox.Text = (string)dogInfo.GetValue(18);
            breedTextBox.Text = (string)dogInfo.GetValue(28);
            weightTextBox.Text = (string)dogInfo.GetValue(38);
            shotsTextBox.Text = (string)dogInfo.GetValue(48);
            availableTextBox.Text = (string)dogInfo.GetValue(58);
        }

        private void DogBernadette_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bernadette.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(9);
            bdayTextBox.Text = (string)dogInfo.GetValue(19);
            breedTextBox.Text = (string)dogInfo.GetValue(29);
            weightTextBox.Text = (string)dogInfo.GetValue(39);
            shotsTextBox.Text = (string)dogInfo.GetValue(49);
            availableTextBox.Text = (string)dogInfo.GetValue(59);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ChooseDogButton_Click(object sender, RoutedEventArgs e)
        {
            DogConfirmation dogConfirmation = new DogConfirmation();
            this.Close();
            dogConfirmation.Show();
        }
    }
}
