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
    /// Interaction logic for Ejercicio7.xaml
    /// </summary>
    public partial class Ejercicio7 : Window
    {
        public Ejercicio7()
        {
            InitializeComponent();
            for (int i = 0; i < 200; i++)
            {
                msgView.Items.Add("---------------------------------------------------");
                msgView.Items.Add("x:"+i);
                msgView.Items.Add("Resultado:" + f(i));

            }
        }

        int f(int x) 
        {
            if (x > 100) return (x - 10);
            else return (f(f(x + 11))); 
        }

    }
}
