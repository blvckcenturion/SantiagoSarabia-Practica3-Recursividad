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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            msgView.Items.Clear();
            verifyPalindrome(txtString.Text);
        }
        // #1 SAPO -> 4 | str[0] = S -> str[4-1 =3] = O
        // #2 BLB 
        // #3 L  
        bool verifyPalindrome(string str)
        {
            if (str.Length == 0 || str.Length == 1) {
                msgView.Items.Add("La cadena de texto ingresada es un palindromo.");
                return true;
            }
            if (str[0] != str[str.Length - 1])
            {
                msgView.Items.Add(str[0] + " no es igual a " + str[str.Length - 1]);
                msgView.Items.Add("La cadena de texto ingresada no es un palindromo.");
                return false;
            }
            return verifyPalindrome(str.Substring(1, str.Length-2));
        }
    }
}
