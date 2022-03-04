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
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {

        // RESULTADO: El valor de Q(3,2) es 1

        // Ejecutamos la funcion recursiva en el constructor.
        public Ejercicio5()
        {
            InitializeComponent();
            // Agregamos el resultado a el ListView
            msgView.Items.Add("El resultado de Q(3,2) es:" + Q(3, 2));
        }
        // Funcion recursiva Q
        int Q(int a, int b)
        {
            // Si a < b retornamos 0
            if (a < b) return 0;
            // Caso contrario retornamos la ejecucion modificando el parametro a, restandole b al valor de a y sumandole 1 al final
            return Q(a - b, b) + 1;
        }

    }
}
