using System.Windows;

namespace TestGraphiques.exo2;

public partial class Exo25Window : Window
{
    public Exo25Window()
    {
        InitializeComponent();
    }
    
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        deuxiemePage deuxiemePage = new deuxiemePage();
        this.Visibility = Visibility.Hidden;
        deuxiemePage.Prenom2.Text = textPrenom.Text;
        deuxiemePage.Nom2.Text = textNom.Text;
        deuxiemePage.Show();
    }

}