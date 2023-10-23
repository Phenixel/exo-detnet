using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace TestGraphiques.exo2;

public partial class Exo24Window : Window
{
    public Exo24Window()
    {
        InitializeComponent();
    }
    
    private void Button1_MouseEnter(object sender, MouseEventArgs e)
    {
        Button2.Background = Brushes.Red;
    }

    private void Button1_MouseLeave(object sender, MouseEventArgs e)
    {
        Button2.Background = null; // Retournez à la couleur par défaut
    }

    private void Button2_MouseEnter(object sender, MouseEventArgs e)
    {
        Button1.Background = Brushes.Blue;
    }

    private void Button2_MouseLeave(object sender, MouseEventArgs e)
    {
        Button1.Background = null; // Retournez à la couleur par défaut
    }


}