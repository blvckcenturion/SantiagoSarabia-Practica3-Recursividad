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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            msgView.Items.Clear();
            messageGenerator(txtMessage.Text, txtMessage.Text.Length - 1);
        }

        string messageGenerator(string initialString, int count)
        {
            if (count == 0) {
                msgView.Items.Add(initialString[0]);
                return initialString[0].ToString();
            } 
            string message = messageGenerator(initialString, count - 1) + initialString[count];
            msgView.Items.Add(message);
            return message;
        }

    }
}
