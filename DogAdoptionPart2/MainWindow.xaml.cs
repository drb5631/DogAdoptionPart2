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
        DogConfirmation dogConfirmation = new DogConfirmation();


        //IEnumerable<string> lines = File.ReadLines("C:/Users/dblon/source/repos/DogAdoptionPart2/DogInformation.txt").ToArray();
        string[] dogInfo = File.ReadLines("C:/Users/dblon/source/repos/DogAdoptionPart2/DogInformation.txt").ToArray();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ChooseDogButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            dogConfirmation.Show();
        }

        private void DogBella_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bella.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/bella.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(0);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(1);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(2);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(3);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(4);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(5);

        }

        private void DogCharlie_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/charlie.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(6);
            bdayTextBox.Text = (string)dogInfo.GetValue(7);
            breedTextBox.Text = (string)dogInfo.GetValue(8);
            weightTextBox.Text = (string)dogInfo.GetValue(9);
            shotsTextBox.Text = (string)dogInfo.GetValue(10);
            availableTextBox.Text = (string)dogInfo.GetValue(11);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/charlie.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(6);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(7);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(8);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(9);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(10);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(11);
        }

        private void DogLuna_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/luna.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(12);
            bdayTextBox.Text = (string)dogInfo.GetValue(13);
            breedTextBox.Text = (string)dogInfo.GetValue(14);
            weightTextBox.Text = (string)dogInfo.GetValue(15);
            shotsTextBox.Text = (string)dogInfo.GetValue(16);
            availableTextBox.Text = (string)dogInfo.GetValue(17);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/luna.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(12);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(13);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(14);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(15);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(16);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(17);
        }

        private void DogLucy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/lucy.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(18);
            bdayTextBox.Text = (string)dogInfo.GetValue(19);
            breedTextBox.Text = (string)dogInfo.GetValue(20);
            weightTextBox.Text = (string)dogInfo.GetValue(21);
            shotsTextBox.Text = (string)dogInfo.GetValue(22);
            availableTextBox.Text = (string)dogInfo.GetValue(23);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/lucy.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(18);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(19);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(20);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(21);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(22);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(23);
        }

        private void DogMax_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/max.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(24);
            bdayTextBox.Text = (string)dogInfo.GetValue(25);
            breedTextBox.Text = (string)dogInfo.GetValue(26);
            weightTextBox.Text = (string)dogInfo.GetValue(27);
            shotsTextBox.Text = (string)dogInfo.GetValue(28);
            availableTextBox.Text = (string)dogInfo.GetValue(29);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/max.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(24);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(25);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(26);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(27);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(28);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(29);
        }

        private void DogBailey_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bailey.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(30);
            bdayTextBox.Text = (string)dogInfo.GetValue(31);
            breedTextBox.Text = (string)dogInfo.GetValue(32);
            weightTextBox.Text = (string)dogInfo.GetValue(33);
            shotsTextBox.Text = (string)dogInfo.GetValue(34);
            availableTextBox.Text = (string)dogInfo.GetValue(35);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/bailey.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(30);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(31);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(32);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(33);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(34);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(35);
        }

        private void DogCooper_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/cooper.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(36);
            bdayTextBox.Text = (string)dogInfo.GetValue(37);
            breedTextBox.Text = (string)dogInfo.GetValue(38);
            weightTextBox.Text = (string)dogInfo.GetValue(39);
            shotsTextBox.Text = (string)dogInfo.GetValue(40);
            availableTextBox.Text = (string)dogInfo.GetValue(41);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/cooper.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(36);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(37);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(38);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(39);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(40);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(41);
        }

        private void DogDaisy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/daisy.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(42);
            bdayTextBox.Text = (string)dogInfo.GetValue(43);
            breedTextBox.Text = (string)dogInfo.GetValue(44);
            weightTextBox.Text = (string)dogInfo.GetValue(45);
            shotsTextBox.Text = (string)dogInfo.GetValue(46);
            availableTextBox.Text = (string)dogInfo.GetValue(47);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/daisy.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(42);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(43);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(44);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(45);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(46);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(47);
        }

        private void DogHexi_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/hexi.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(48);
            bdayTextBox.Text = (string)dogInfo.GetValue(49);
            breedTextBox.Text = (string)dogInfo.GetValue(50);
            weightTextBox.Text = (string)dogInfo.GetValue(51);
            shotsTextBox.Text = (string)dogInfo.GetValue(52);
            availableTextBox.Text = (string)dogInfo.GetValue(53);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/hexi.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(48);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(49);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(50);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(51);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(52);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(53);
        }

        private void DogBernadette_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bernadette.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(54);
            bdayTextBox.Text = (string)dogInfo.GetValue(55);
            breedTextBox.Text = (string)dogInfo.GetValue(56);
            weightTextBox.Text = (string)dogInfo.GetValue(57);
            shotsTextBox.Text = (string)dogInfo.GetValue(58);
            availableTextBox.Text = (string)dogInfo.GetValue(59);

            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/bernadette.jpg", UriKind.Relative));
            dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(54);
            dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(55);
            dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(56);
            dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(57);
            dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(58);
            dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(59);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
