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

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para DiarioWindow.xaml
    /// </summary>
    public partial class DiarioWindow : Window
    {
        public DiarioWindow()
        {
            InitializeComponent();
            listTurmas.ItemsSource = NTurma.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listTurmas.SelectedItem != null)
            {
                Turma t = (Turma)listTurmas.SelectedItem;
                listAlunos.ItemsSource = null;
                listAlunos.ItemsSource = NAluno.Listar(t);
            }
            else
                MessageBox.Show("É preciso selecionar uma turma");
        }
    }
}
