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

namespace DogAdoptionPart2
{
    /// <summary>
    /// Interaction logic for DogConfirmation.xaml
    /// </summary>
    public partial class DogConfirmation : Window
    {
        public DogConfirmation()
        {
            InitializeComponent();
        }

        private void CancelDogButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
