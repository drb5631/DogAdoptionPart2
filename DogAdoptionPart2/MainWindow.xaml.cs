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

namespace DogAdoptionPart2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
        }

        private void DogCharlie_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/charlie.jpg", UriKind.Relative));
        }

        private void DogLuna_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/luna.jpg", UriKind.Relative));
        }

        private void DogLucy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/lucy.jpg", UriKind.Relative));
        }

        private void DogMax_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/max.jpg", UriKind.Relative));
        }

        private void DogBailey_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bailey.jpg", UriKind.Relative));
        }

        private void DogCooper_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/cooper.jpg", UriKind.Relative));
        }

        private void DogDaisy_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/daisy.jpg", UriKind.Relative));
        }

        private void DogHexi_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/hexi.jpg", UriKind.Relative));
        }

        private void DogBernadette_Selected(object sender, RoutedEventArgs e)
        {
            dogImageDisplay.Source = new BitmapImage(new Uri("images/bernadette.jpg", UriKind.Relative));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
