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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            msgView.Items.Clear();
            int num;
            bool isValid = int.TryParse(txtNumber.Text, out num);
            if(isValid && num > 0)
            {
                int res = SumNums(num);
                msgView.Items.Add("Resultado :" + res);
            }
        }

        int SumNums(int num)
        {
            if (num == 0) return 0;
            int numRes;
            if (num % 2 == 0)
            {
                numRes = SumNums(num - 2);
                int res = numRes + num;
                msgView.Items.Add(numRes + "+" + num + "=" + res);
                return res;
            }
            return SumNums(num - 1);
        }

    }
}
