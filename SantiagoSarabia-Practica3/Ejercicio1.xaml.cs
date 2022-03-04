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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        // Boton Calcular 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Limpiar el ListView que contiene el resultado
            resultView.Items.Clear();
            // Definicion de variables int previa a la conversion de los strings 
            int initialAmount, interestRate, years;
            // Realizando el parsing para convertir los 3 textbox de string a int
            bool isValidAmount = int.TryParse(txtInitialAmount.Text, out initialAmount);
            bool isValidInterest = int.TryParse(txtInterestRate.Text, out interestRate);
            bool isValidYears = int.TryParse(txtYears.Text, out years);
            // Realizando la validacion de los 3 textbox para confirmar que todos tienen valores de tipo int validos para proceder a la ejecucion de la funcion recursiva
            if (isValidAmount && isValidInterest && isValidYears) 
            {
               // Haciendo el llamado a la funcion recursiva y almacenando el resultado para despues agregarlo como ultimo elemento del ListView
               double res = calculateCapital(initialAmount, interestRate, years);
               resultView.Items.Add("Resultado: " + res);
            }
        }
        // Funcion recursiva para calcular el capital despues de x years
        double calculateCapital(int initialAmount, int interestRate, int years)
        {
            // Si years es 0 retornamos el monto inicial
            if (years == 0) {
                resultView.Items.Add("Año 0 | Monto Total:" + initialAmount);
                return initialAmount;
            }
            // llamamos a calculateCapital con los mismos parametros, decrementando years en 1
            double cap = calculateCapital(initialAmount, interestRate, years - 1);
            // Calculamos el total considerando el monto inicial mas el 10% del mismo.
            double total = cap + (cap*interestRate)/100;
            // Agregamos el resultado a el ListView
            resultView.Items.Add("Año: " + years + " | Monto Total: " + total);
            return total;
        }
    }
}
