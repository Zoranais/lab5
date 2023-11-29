using Component;
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

namespace lab6;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Calculate_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            double x = Convert.ToDouble(XInput.Text);
            int n = Convert.ToInt32(NInput.Text);

            if(Math.Abs(x) > 3 * Math.PI) 
            {
                MessageBox.Show("Invalid x range");
                return;
            }

            var resultIterative = ComponentClass.CalculateIterativly(x, n);
            double sum = 0;
            var resultRec = ComponentClass.CalculateRec(x, n, ref sum);

            MessageBox.Show(
                $"Iterative: {resultIterative}\n" +
                $"Recursive: {resultRec}\n" +
                $"Math.Exp(x): {Math.Exp(x)}");
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid input");
        }
    }
}