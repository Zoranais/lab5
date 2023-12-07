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
            double sx = Convert.ToDouble(XStartInput.Text);
            double ex = Convert.ToDouble(XEndInput.Text);
            int n = Convert.ToInt32(NInput.Text);
            double step = Convert.ToDouble(StepInput.Text);

            if(Math.Abs(sx) > 3 * Math.PI && Math.Abs(ex) > 3 * Math.PI) 
            {
                MessageBox.Show("Invalid x range");
                return;
            }

            for (double i = sx; i <= ex; i += step)
            {
                var resultIterative = ComponentClass.CalculateIterativly(i, n);
                double sum = 0;
                var resultRec = ComponentClass.CalculateRec(i, n, ref sum);
                var actual = Math.Exp(i);

                Output.Items.Add($"x: {i}; iterative: {resultIterative}; recursive: {resultRec}; Math.Exp: {actual};");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid input");
        }
    }
}