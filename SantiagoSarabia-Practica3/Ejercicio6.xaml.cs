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
    /// Interaction logic for Ejercicio6.xaml
    /// </summary>
    public partial class Ejercicio6 : Window
    {
        public Ejercicio6()
        {
            // Funcion para encontrar los factores de un numero
            InitializeComponent();
        }
        // 10, 2
        // #1 10,2 > 1 -> 10 % 2 == 0 -> print(2)
        // #2 5,2 > 1 -> 5 % 2 == 0 -> 
        // #3 5,3 
        // #4 5,4
        // #5 5,5 > 1 -> 5 % 5 == 0 -> print(5)
        // #5 1,5

        
        void findFactorsOf(int num, int div)
        {
            if (num > 1)
            {
                if (num % div == 0)
                {
                    msgView.Items.Add(div);
                    findFactorsOf(num / div, div);
                } else
                {
                    findFactorsOf(num, div+1);
                }
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            msgView.Items.Clear();
            int num;
            bool isValid = int.TryParse(txtNum.Text, out num);
            if(isValid)
            {
                msgView.Items.Add("Los factores de " + num + " son:");
                findFactorsOf(num, 1);
            }
        }
    }
}
