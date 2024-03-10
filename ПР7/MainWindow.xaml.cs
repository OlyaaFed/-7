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

namespace ПР7
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
        int[] arrayX;
        int index;
        int multip = 1;
        private void BtnCreateArray_Click(object sender, RoutedEventArgs e)
        {
            LstArray.Items.Clear();
            arrayX = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arrayX[i] = rnd.Next(-1000, 1000);
                LstArray.Items.Add($"#{arrayX[i]}");
            }
        }

        private void BtnSolveArray_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (arrayX[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            for (int j = index; j < 10; j++)
            {
                multip *= arrayX[j];
            }
            LstArray.Items.Add($"#{multip}");
        }
    }
}
