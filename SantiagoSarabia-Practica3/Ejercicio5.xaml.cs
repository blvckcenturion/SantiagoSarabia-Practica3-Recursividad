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

namespace SantiagoSarabia_Practica3
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
            msgView.Items.Add("El resultado de Q(3,2) es:" + Q(3, 2));
        }
        // a = 3, b = 2
        // #1 0 + 1
        // #2 0
        int Q(int a, int b)
        {
            if (a < b) return 0;
            return Q(a - b, b) + 1;
        }

    }
}
