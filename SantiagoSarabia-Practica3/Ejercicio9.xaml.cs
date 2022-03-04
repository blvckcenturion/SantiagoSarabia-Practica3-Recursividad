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
    /// Interaction logic for Ejercicio9.xaml
    /// </summary>
    public partial class Ejercicio9 : Window
    {
        // RESULTADO: Pasado un año entero, el granjero podrá poner a disposición del mercado un total de 144 parejas de conejos o 288 conejos.

        public Ejercicio9()
        {

            InitializeComponent();
            findTotalPairs(12,1,0,12);
        }

        void findTotalPairs(int monthsNum, int currentCount, int pastCount, int initialMonths)
        {
            if (monthsNum == 1) return;
            int totalPairs = currentCount + pastCount;
            msgView.Items.Add(totalPairs + " Parejas");
            findTotalPairs(monthsNum - 1, totalPairs, currentCount, initialMonths);
        }

    }
}
