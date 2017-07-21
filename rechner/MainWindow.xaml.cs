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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bplus_Click(object sender, RoutedEventArgs e)
        {
            //VARIABLEN
            int zahl1;
            int zahl2;
            int ergebnis;
            //zuweisungen
            zahl1 = Convert.ToInt32(tb1.Text);
            zahl2 = Convert.ToInt32(tb2.Text);
            ergebnis = zahl1 + zahl2;

            //ausgabe
            tergebnis.Text = Convert.ToString(ergebnis);
        }

        private void bminus_Click(object sender, RoutedEventArgs e)
        {
            //VARIABLEN
            int zahl1;
            int zahl2;
            int ergebnis;
            //zuweisungen
            zahl1 = Convert.ToInt32(tb1.Text);
            zahl2 = Convert.ToInt32(tb2.Text);
            ergebnis = zahl1 - zahl2;

            //ausgabe
            tergebnis.Text = Convert.ToString(ergebnis);
        }

        private void bdividiert_Click(object sender, RoutedEventArgs e)
        {
            //VARIABLEN
            Double zahl1;
            Double zahl2;
            Double ergebnis;
         
            //zuweisungen
            zahl1 = Convert.ToInt32(tb1.Text);
            zahl2 = Convert.ToInt32(tb2.Text);
            ergebnis = zahl1 / zahl2;

            //ausgabe
            tergebnis.Text = Convert.ToString(ergebnis);
        }

        private void bmal_Click(object sender, RoutedEventArgs e)
        {
            //VARIABLEN
            int zahl1;
            int zahl2;
            int ergebnis;
            //zuweisungen
            zahl1 = Convert.ToInt32(tb1.Text);
            zahl2 = Convert.ToInt32(tb2.Text);
            ergebnis = zahl1 * zahl2;

            //ausgabe
            tergebnis.Text = Convert.ToString(ergebnis);
        }

        private void button_ul_Click(object sender, RoutedEventArgs e)
        {
            int modulo;
            //zuweisungen

            //ausgabe
            MessageBox.Show(modulo.ToString());
        }
    }
}
