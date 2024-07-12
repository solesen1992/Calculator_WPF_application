using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_WPF_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regnetegn regnetegn;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Dette er en enum der definere de gængse regnetegn
        /// </summary>
        enum Regnetegn
        {
            Plus,
            Minus,
            Divider,
            Gange
        }

        //Den bette lommeregner v.2.01

        private double regneFunktion(Regnetegn regneTegn)
        {
            //Variabler
            double tal1 = 0;
            double tal2 = 0;
            double resultat = 0;
            try
            {
                //Konverterer til en double. Tager tal fra tbTal1 og 2, som er tekst og smider over i variablen tal1 og tal2.
                tal1 = Convert.ToDouble(tbTal1.Text);
                tal2 = Convert.ToDouble(tbTal2.Text);
            }
            catch (Exception exc)
            {
                //Hvis der opstår en fejl, så vises denne besked. Fx ved andet end tal.
                MessageBox.Show(exc.Message, "How! Der er opstået en fejl...");
            }
            if (regneTegn == Regnetegn.Plus)
            {
                resultat = tal1 + tal2;
            }
            else if (regneTegn == Regnetegn.Minus)
            {
                resultat = tal1 - tal2;
            }
            else if (regneTegn == Regnetegn.Gange)
            {
                resultat = tal1 * tal2;
            }
            else if (regneTegn == Regnetegn.Divider)
            {
                resultat = tal1 / tal2;
            }

            return resultat;
        }

        //Så den ved hvilken knap, der gør hvad.
        private void btn_Plus_Click(object sender, RoutedEventArgs e)
        {
            //får koblet + til knappen btn_plus_click
            double resultat = regneFunktion(Regnetegn.Plus);
            tbResultat.Text = resultat.ToString();
        }

        private void btn_Minus_Click(object sender, RoutedEventArgs e)
        {
            double resultat = regneFunktion(Regnetegn.Minus);
            tbResultat.Text = resultat.ToString();
        }

        private void btn_Gange_Click(object sender, RoutedEventArgs e)
        {
            double resultat = regneFunktion(Regnetegn.Gange);
            tbResultat.Text = resultat.ToString();
        }

        private void btn_Divider_Click(object sender, RoutedEventArgs e)
        {
            double resultat = regneFunktion(Regnetegn.Divider);
            tbResultat.Text = resultat.ToString();
        }
    }
}