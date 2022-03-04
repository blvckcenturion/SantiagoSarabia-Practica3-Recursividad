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
        //RESULTADO: El algoritmo propuesto en el ejercicio 6, es una función que encuentra los factores de un numero haciendo uso de la recursión, por lo tanto el nombre adecuado para la función seria EncontrarFactoresDe() o FindFactorsOf()

        public Ejercicio6()
        {
            // Funcion para encontrar los factores de un numero
            InitializeComponent();
        }
        
        // Funcion recursiva para encontrar los factores de num con valor inicial a verificar div
        void findFactorsOf(int num, int div)
        {
            // Verificamos si el numero es mayor a 1
            if (num > 1)
            {
                // Verificamos si el resto de num entre div es 0
                // Si es verdadero entonces agregamos el valor de div al ListView
                // Volvemos a ejecutar la funcion pasando num entre div como parametro num
                // Caso contrario ejecutamos la funcion pasando num y div + 1 como parametro div
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
        // Boton encontrar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Limpiamos el ListView
            msgView.Items.Clear();
            // Realizamos la verificacion para nuestro textbox
            int num;
            bool isValid = int.TryParse(txtNum.Text, out num);
            // Si el numero es valido realizamos la ejecucion de la funcion recursiva
            if(isValid)
            {
                msgView.Items.Add("Los factores de " + num + " son:");
                findFactorsOf(num, 2);
            }
        }
    }
}
