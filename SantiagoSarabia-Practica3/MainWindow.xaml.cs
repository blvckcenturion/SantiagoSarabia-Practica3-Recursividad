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

namespace SantiagoSarabia_Practica3
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio1().Show();
        }

        private void btn1_Copy_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio2().Show();
        }

        private void btn1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio3().Show();
        }

        private void btn1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio4().Show();
        }

        private void btn1_Copy3_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio5().Show();
        }

        private void btn1_Copy4_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio6().Show();
        }

        private void btn1_Copy5_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio7().Show();
        }

        private void btn1_Copy7_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio9().Show();
        }

        private void btn1_Copy6_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio8().Show();
        }
    }
}
