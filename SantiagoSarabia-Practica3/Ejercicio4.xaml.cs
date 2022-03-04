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
    /// Interaction logic for Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        // Boton Verificar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Realizamos la limpieza al ListView
            msgView.Items.Clear();
            // Pasamos a la ejecucion de la funcion recursiva
            verifyPalindrome(txtString.Text);
        }
        
        // Funcion recursiva para verificar si el parametro str es un palindromo
        bool verifyPalindrome(string str)
        {
            // Si la longitud del string es 0, es decir que ya no existen valores para comparar
            // O la longitud es 1, es decir que solamente queda 1 caracter
            // Confirmamos que el parametro str es un palindromo
            if (str.Length == 0 || str.Length == 1) {
                msgView.Items.Add("La cadena de texto ingresada es un palindromo.");
                return true;
            }
            // Realizamos una verificacion para ver si es que el primer caracter y el ultimo de la cadena no son iguales
            // Caso de que no sean iguales confirmamos que el parametro str no es un palindromo
            if (str[0] != str[str.Length - 1])
            {
                msgView.Items.Add(str[0] + " no es igual a " + str[str.Length - 1]);
                msgView.Items.Add("La cadena de texto ingresada no es un palindromo.");
                return false;
            }
            // Caso de que el primer caracter y el ultimo de la cadena sean iguales retornamos la ejecucion de la cadena eliminando el primer y el ultimo caracter del str y pasando el resultado
            // Como parametro
            return verifyPalindrome(str.Substring(1, str.Length-2));
        }
    }
}
