using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
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

namespace S05_Events_i_Grid
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

        private void Button_Click_ter(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Marc-André ter Stegen" + "\r\n" + "Porter" + "\r\n" + "Alemany" + "\r\n" + "31 anys" );
        }

        private void Button_Click_balde(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alejandro Balde" + "\r\n" + "Lateral Esquerre" + "\r\n" + "Espanyol" + "\r\n" + "19 anys");
        }

        private void Button_Click_kounde(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Jules Koundé" + "\r\n" + "Defensa" + "\r\n" + "Frances" + "\r\n" + "24 anys");
        }

        private void Button_Click_araujo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ronald Araújo" + "\r\n" + "Defensa" + "\r\n" + "Uruguaià" + "\r\n" + "24 anys");
        }

        private void Button_Click_cancelo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("João Cancelo" + "\r\n" + "Lateral Dret" + "\r\n" + "Portuguès" + "\r\n" + "29 anys");
        }

        private void Button_Click_gavi(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gavi" + "\r\n" + "Migcampista" + "\r\n" + "Espanyol" + "\r\n" + "19 anys");
        }

        private void Button_Click_dejong(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Frenkie de Jong" + "\r\n" + "Migcampista" + "\r\n" + "Neerlandes" + "\r\n" + "26 anys");
        }

        private void Button_Click_pedri(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pedri" + "\r\n" + "Migcampista" + "\r\n" + "Espanyol" + "\r\n" + "20 anys");
        }

        private void Button_Click_joao(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("João Félix" + "\r\n" + "Davanter" + "\r\n" + "Portuguès" + "\r\n" + "23 anys");
        }

        private void Button_Click_lewan(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Robert Lewandowski" + "\r\n" + "Davanter" + "\r\n" + "Polonès" + "\r\n" + "35 anys");
        }

        private void Button_Click_rap(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Raphinha" + "\r\n" + "Davanter" + "\r\n" + "Brasiler" + "\r\n" + "26 anys");
        }

        private void Button_Click_bcn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Futbol Club Barcelona" + "\r\n" + "Estadi: Spotify Camp Nou" + "\r\n" + "Fundació 1899");
        }

        private void Button_Click_gir(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Girona Fútbol Club" + "\r\n" + "Estadi: Estadi Montilivi" + "\r\n" + "Fundació 1930");
        }

        private void Button_Click_xavi(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Xavi Hernández" + "\r\n" + "Espanyol" + "\r\n" + "43 anys");
        }

        private void Button_Click_mich(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Míchel" + "\r\n" + "Espanyol" + "\r\n" + "47 anys");
        }

        private void Button_Click_gaz(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Paulo Gazzaniga" + "\r\n" + "Porter" + "\r\n" + "Argentí" + "\r\n" + "31 anys");
        }

        private void Button_Click_arnau(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Arnau Martínez" + "\r\n" + "Lateral Dret" + "\r\n" + "Espanyol" + "\r\n" + "20 anys");
        }

        private void Button_Click_eric(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Eric García" + "\r\n" + "Defensa" + "\r\n" + "Espanyol" + "\r\n" + "22 anys");
        }

        private void Button_Click_david(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("David López" + "\r\n" + "Defensa" + "\r\n" + "Espanyol" + "\r\n" + "34 anys");
        }

        private void Button_Click_mig(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Miguel Gutiérrez" + "\r\n" + "Lateral Esquerre" + "\r\n" + "Espanyol" + "\r\n" + "22 anys");
        }

        private void Button_Click_yan(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yangel Herrera" + "\r\n" + "Migcampista" + "\r\n" + "Veneçolà" + "\r\n" + "25 anys");
        }

        private void Button_Click_aleix(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aleix García" + "\r\n" + "Migcampista" + "\r\n" + "Espanyol" + "\r\n" + "26 anys");
        }

        private void Button_Click_ivan(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Iván Martín" + "\r\n" + "Migcampista" + "\r\n" + "Espanyol" + "\r\n" + "24 anys");
        }
        
        private void Button_Click_tsy(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Viktor Tsygankov" + "\r\n" + "Davanter" + "\r\n" + "Ucraïnès" + "\r\n" + "25 anys");
        }

        private void Button_Click_stuani(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cristhian Stuani" + "\r\n" + "Davanter" + "\r\n" + "Uruguaià" + "\r\n" + "36 anys");
        }

        private void Button_Click_savio(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sávio Moreira" + "\r\n" + "Davanter" + "\r\n" + "Brasiler" + "\r\n" + "19 anys");
        }
    }
}
