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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        // Boton mostrar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Limpiar el ListView que contiene el resultado
            msgView.Items.Clear();
            // Ejecutar la funcion recursiva pasando el valor del textbox y la longitud de la cadena decrementada en 1
            messageGenerator(txtMessage.Text, txtMessage.Text.Length - 1);
        }
        // Funcion recursiva para generar el mensaje
        string messageGenerator(string initialString, int count)
        {
            // Si la cuenta es 0 entonces agregamos el indice 0 de nuestra cadena a el ListView y retornamos el valor del indice 0
            if (count == 0) {
                msgView.Items.Add(initialString[0]);
                return initialString[0].ToString();
            } 
            // Concatenamos el valor de la ejecucion de la misma funcion decrementando la cuenta en 1 y el indice actual de la cuenta.
            string message = messageGenerator(initialString, count - 1) + initialString[count];
            // Agregamos el resultado del mensaje al ListView y retornamos el valor
            msgView.Items.Add(message);
            return message;
        }

    }
}
