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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultView.Items.Clear();
            int initialAmount, interestRate, years;

            bool isValidAmount = int.TryParse(txtInitialAmount.Text, out initialAmount);
            bool isValidInterest = int.TryParse(txtInterestRate.Text, out interestRate);
            bool isValidYears = int.TryParse(txtYears.Text, out years);

            if (isValidAmount && isValidInterest && isValidYears) 
            {
               double res = calculateCapital(initialAmount, interestRate, years);
                resultView.Items.Add("Resultado: " + res);
            }
        }

        double calculateCapital(int initialAmount, int interestRate, int years)
        {
            if (years == 0) {
                resultView.Items.Add("Año 0 | Monto Total:" + initialAmount);
                return initialAmount;
            }
            double cap = calculateCapital(initialAmount, interestRate, years - 1);
            double total = cap + (cap*interestRate)/100;
            resultView.Items.Add("Año: " + years + " | Monto Total: " + total);   
            return total;
        }
    }
}
