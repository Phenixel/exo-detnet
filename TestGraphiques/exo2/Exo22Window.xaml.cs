using System;
using System.Windows;

namespace TestGraphiques.exo2;

public partial class Exo22Window : Window
{
    public Exo22Window()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            // Récupérez les valeurs des TextBox et convertissez-les en double
            double chiffre1 = Convert.ToDouble(nb1.Text);
            double chiffre2 = Convert.ToDouble(nb2.Text);

            // Effectuez la multiplication
            double resultat = chiffre1 * chiffre2;

            // Affichez le résultat dans un message d'alerte
            MessageBox.Show($"Le résultat de la multiplication est : {resultat}", "Résultat de la multiplication");
        }
        catch (FormatException)
        {
            // Gérez l'erreur si les valeurs ne sont pas valides
            MessageBox.Show("Veuillez entrer des nombres valides.", "Erreur", MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
        catch (Exception ex)
        {
            // Gérez d'autres exceptions si nécessaire
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }
}