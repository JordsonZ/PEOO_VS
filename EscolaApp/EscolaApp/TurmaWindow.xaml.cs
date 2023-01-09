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
            // Novo objeto com os dados da turma que será inserida
            Turma t = new Turma();
            t.Id = int.Parse(txtId.Text);
            t.Curso = txtCurso.Text;
            t.Descricao = txtTurma.Text;
            t.AnoLetivo = int.Parse(txtAno.Text);
            // Inserir a turma na lista de turmas
            NTurma.Inserir(t);
            // Lista a turma inserida
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listTurmas.ItemsSource = null;
            listTurmas.ItemsSource = NTurma.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Turma t = new Turma();
            t.Id = int.Parse(txtId.Text);
            t.Curso = txtCurso.Text;
            t.Descricao = txtTurma.Text;
            t.AnoLetivo = int.Parse(txtAno.Text);
            // Inserir a turma na lista de turmas
            NTurma.Atualizar(t);
            // Lista as turmas cadastradas
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Turma t = new Turma();
            t.Id = int.Parse(txtId.Text);
            // Inserir a turma na lista de turmas
            NTurma.Excluir(t);
            // Lista as turmas cadastradas
            ListarClick(sender, e);
        }

        private void listTurmas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listTurmas.SelectedItem != null)
            {
                Turma obj = (Turma)listTurmas.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtCurso.Text = obj.Curso;
                txtTurma.Text = obj.Descricao;
                txtAno.Text = obj.AnoLetivo.ToString();
            }
        }
    }
}
