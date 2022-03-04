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
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        // Boton Calcular
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Limpiar el ListView que contiene el resultado
            msgView.Items.Clear();
            // Realizamos la verificacion para validar que el numero ingresado en el textbox es valido.
            int num;
            bool isValid = int.TryParse(txtNumber.Text, out num);
            // Si el valor es valido y el numero es mayor a 0 entonces procedemos a ejecutar la funcion recursiva
            // Posteriormente a agregar el resultado como ultimo elemento del ListView
            if(isValid && num > 0)
            {
                int res = SumNums(num);
                msgView.Items.Add("Resultado :" + res);
            }
        }
        // Metodo recursivo para sumar todos los numeros pares 
        int SumNums(int num)
        {
            // Si el numero es igual a 0 retornamos 0
            if (num == 0) return 0;
            // Verificamos si el numero es par
            if (num % 2 == 0)
            {
                // Definimos una variable que guarda el resultado de la ejecucion pasando como parametro el numero decrementado en 2
                int numRes = SumNums(num - 2);
                // Realizamos una suma con la variable declarada + el parametro num
                int res = numRes + num;
                // Agregamos el resultado al ListView y retornamos el resultado
                msgView.Items.Add(numRes + "+" + num + "=" + res);
                return res;
            }
            // Caso de que el numero no sea par retornamos la ejecucion de la funcion recursiva pasando como parametro el numero decrementado en 1
            return SumNums(num - 1);
        }

    }
}
