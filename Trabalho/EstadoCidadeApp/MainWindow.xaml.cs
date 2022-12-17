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

namespace EstadoCidadeApp
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

        private Estado n;
        private Cidade c;
        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            n = new Estado(txt1.Text);
            Cidade c = new Cidade(txt2.Text);
            c.SetArea(double.Parse(txt3.Text));
            c.SetPopulacao(int.Parse(txt4.Text));
            List.ItemsSource = null;
            List.ItemsSource = c.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{n.Populacao()}");
        }
    }
}
