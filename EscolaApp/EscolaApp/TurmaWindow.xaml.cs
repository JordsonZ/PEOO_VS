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
    /// Lógica interna para TurmaWindow.xaml
    /// </summary>
    public partial class TurmaWindow : Window
    {
        public TurmaWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            t.Id = int.Parse(txtId.Text);
            t.Curso = txtCurso.Text;
            t.Descricao = txtTurma.Text;
            t.AnoLetivo = int.Parse(txtAno.Text);
            NTurma.Inserir(t);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listTurmas.ItemsSource = null;
            listTurmas.ItemsSource = NTurma.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            t.Id = int.Parse(txtId.Text);
            t.Curso = txtCurso.Text;
            t.Descricao = txtTurma.Text;
            t.AnoLetivo = int.Parse(txtAno.Text);
            NTurma.Atualizar(t);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            t.Id = int.Parse(txtId.Text);
            NTurma.Excluir(t);
            ListarClick(sender, e);
        }
    }
}
