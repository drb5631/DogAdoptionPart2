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
            nameTextBox.Text = (string )dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogCharlie_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/charlie.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogLuna_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/luna.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogLucy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/lucy.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogMax_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/max.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogBailey_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bailey.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogCooper_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/cooper.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogDaisy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/daisy.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogHexi_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/hexi.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void DogBernadette_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bernadette.jpg", UriKind.Relative));
            nameTextBox.Text = (string)dogInfo.GetValue(0);
            bdayTextBox.Text = (string)dogInfo.GetValue(1);
            breedTextBox.Text = (string)dogInfo.GetValue(2);
            weightTextBox.Text = (string)dogInfo.GetValue(3);
            shotsTextBox.Text = (string)dogInfo.GetValue(4);
            availableTextBox.Text = (string)dogInfo.GetValue(5);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
