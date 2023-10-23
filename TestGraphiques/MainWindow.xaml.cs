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
using TestGraphiques.exo2;

namespace TestGraphiques
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Exo11Button_Click(object sender, RoutedEventArgs e)
        {
            Exo11Window exo11Window = new Exo11Window();
            exo11Window.Show();
        }

        private void Exo12Button_Click(object sender, RoutedEventArgs e)
        {
            Exo12Window exo12Window = new Exo12Window();
            exo12Window.Show();
        }
        
        private void Exo13Button_Click(object sender, RoutedEventArgs e)
        {
            Exo13Windows exo13Window = new Exo13Windows();
            exo13Window.Show();
        }

        private void Exo14Button_Click(object sender, RoutedEventArgs e)
        {
            Exo14Windows exo14Window = new Exo14Windows();
            exo14Window.Show();
        }

        private void Exo15Button_Click(object sender, RoutedEventArgs e)
        {
            Exo15Windows exo15Window = new Exo15Windows();
            exo15Window.Show();
        }

        private void Exo16Button_Click(object sender, RoutedEventArgs e)
        {
            Exo16Windows exo16Window = new Exo16Windows();
            exo16Window.Show();
        }

        private void Exo17Button_Click(object sender, RoutedEventArgs e)
        {
            Exo17Windows exo17Window = new Exo17Windows();
            exo17Window.Show();
        }
        
        private void Exo21Button_Click(object sender, RoutedEventArgs e)
        {
            Exo21Window exo21Window = new Exo21Window();
            exo21Window.Show();
        }
        
        private void Exo22Button_Click(object sender, RoutedEventArgs e)
        {
            Exo22Window exo22Window = new Exo22Window();
            exo22Window.Show();
        }
        
        private void Exo23Button_Click(object sender, RoutedEventArgs e)
        {
            Exo23Window exo23Window = new Exo23Window();
            exo23Window.Show();
        }
        
        private void Exo24Button_Click(object sender, RoutedEventArgs e)
        {
            Exo24Window exo24Window = new Exo24Window();
            exo24Window.Show();
        }
        
        private void Exo25Button_Click(object sender, RoutedEventArgs e)
        {
            Exo25Window exo25Window = new Exo25Window();
            exo25Window.Show();
        }

    }
}