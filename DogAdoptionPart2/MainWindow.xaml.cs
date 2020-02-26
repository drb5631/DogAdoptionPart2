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
    public partial class MainWindow : Window
    {
        DogConfirmation dogConfirmation = new DogConfirmation();

        //IEnumerable<string> lines = File.ReadLines("C:/Users/dblon/source/repos/DogAdoptionPart2/DogInformation.txt").ToArray();
        string[] dogInfo = File.ReadLines("C:/Users/dblon/source/repos/DogAdoptionPart2/DogInformation.txt").ToArray();
        string[] dogImages = Directory.GetFiles("C:/Users/dblon/source/repos/DogAdoptionPart2/DogAdoptionPart2/images").ToArray();

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
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/bella.jpg", UriKind.Relative));
            getDogInfo(0); 
        }

        private void DogCharlie_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/charlie.jpg", UriKind.Relative));         
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/charlie.jpg", UriKind.Relative));
            getDogInfo(6);
        }

        private void DogLuna_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/luna.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/luna.jpg", UriKind.Relative));
            getDogInfo(12);
        }

        private void DogLucy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/lucy.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/lucy.jpg", UriKind.Relative));
            getDogInfo(18);
        }
        private void DogMax_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/max.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/max.jpg", UriKind.Relative));
            getDogInfo(24);
        }

        private void DogBailey_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bailey.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/bailey.jpg", UriKind.Relative));
            getDogInfo(30);
        }

            private void DogCooper_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/cooper.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/cooper.jpg", UriKind.Relative));
            getDogInfo(36);
        }

            private void DogDaisy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/daisy.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/daisy.jpg", UriKind.Relative));
            getDogInfo(42);
        }

            private void DogHexi_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/hexi.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/hexi.jpg", UriKind.Relative));
            getDogInfo(48);
        }

            private void DogBernadette_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bernadette.jpg", UriKind.Relative));
            dogConfirmation.confirmDogImageDisplay.Source = new BitmapImage(new Uri("images/bernadette.jpg", UriKind.Relative));
            getDogInfo(54);

        }

            public void getDogInfo(int indexNumber)
        {

                nameTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                dogConfirmation.nameTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                indexNumber++;

                bdayTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                dogConfirmation.bdayTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                indexNumber++;

                breedTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                dogConfirmation.breedTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                indexNumber++;

                weightTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                dogConfirmation.weightTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                indexNumber++;

                shotsTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                dogConfirmation.shotsTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                indexNumber++;

                availableTextBox.Text = (string)dogInfo.GetValue(indexNumber);
                dogConfirmation.availableTextBox.Text = (string)dogInfo.GetValue(indexNumber);

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}