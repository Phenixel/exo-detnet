using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace TestGraphiques.exo2
{
    public partial class Exo23Window : Window
    {
        private List<string> urls = new List<string>
        {
            "https://www.github.com",
            "https://www.google.com",
            "https://www.samsung.com",
            "https://www.notion.so",
            "https://www.microsoft.com"
        };

        private string randomUrl;

        public Exo23Window()
        {
            InitializeComponent();

            Random random = new Random();
            randomUrl = urls[random.Next(urls.Count)];
            textBlock.Text = $"Quel est le nom de domaine dans '{randomUrl}' ?";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (answer.Text.Equals(new Uri(randomUrl).Host))
                {
                    check.Fill = Brushes.Green;
                }
                else
                {
                    check.Fill = Brushes.Red;
                }
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Veuillez entrer une URL valide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}