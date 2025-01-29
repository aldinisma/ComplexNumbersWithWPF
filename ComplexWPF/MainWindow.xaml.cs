using ComplexLib;
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

namespace ComplexWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComplexNumber number1 = new ComplexNumber();
            ComplexNumber number2 = new ComplexNumber();
            ComplexCalculator calc = new ComplexCalculator();

            //Check für NULL Werte
            if (string.IsNullOrEmpty(real_eins.Text) || string.IsNullOrEmpty(real_zwei.Text) || string.IsNullOrEmpty(img_eins.Text) || string.IsNullOrEmpty(img_zwei.Text))
            {
                MessageBox.Show("Eingabe darf nur Double Werte haben!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            number1.Real = Convert.ToDouble(real_eins.Text);
            number1.Img = Convert.ToDouble(img_eins.Text);

            number2.Real = Convert.ToDouble(real_zwei.Text);
            number2.Img = Convert.ToDouble(img_zwei.Text);

            ComplexNumber result = new ComplexNumber();
            if (combo_rechenart.Text == "Addieren")
            {
                result = calc.Add(number1, number2);
            }
            else if (combo_rechenart.Text == "Subtrahieren")
            {
                result = calc.Sub(number1, number2);
            }
            else if (combo_rechenart.Text == "Multiplizieren")
            {
                result = calc.Mul(number1, number2);
            }
            else if (combo_rechenart.Text == "Dividieren")
            {
                try
                {
                    result = calc.Div(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show("Division durch 0 nicht möglich!!!!!");
                    return;
                }
            }
            //Bild wechseln
            if (combo_darstellung.Text == "Polarform Darstellung")
            {
                output_result.Content = result.PrintPolar(result);
                ausgabe_img.Source = new BitmapImage(new Uri("img/complexNumPolar.png", UriKind.Relative));
            }
            else if (combo_darstellung.Text == "Kartesische Darstellung")
            {
                output_result.Content = result.ToString();
                ausgabe_img.Source = new BitmapImage(new Uri("img/complexNum.png", UriKind.Relative));

            }

        }
    }
    
}