using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TestGraphiques.exo2;

public partial class Exo21Window : Window
{
    public Exo21Window()
    {
        InitializeComponent();
    }
    
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button bouton = (Button)sender;
        bouton.Background = Brushes.Red;
    }

}