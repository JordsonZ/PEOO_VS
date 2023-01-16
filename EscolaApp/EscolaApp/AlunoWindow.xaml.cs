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
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Aluno t = new Aluno();
            t.Id = int.Parse(txtId.Text);
            t.Nome = txtNome.Text;
            t.Matricula = txtMatricula.Text;
            t.Email = txtEmail.Text;
            // Inserir a turma na lista de turmas
            NAluno.Inserir(t);
            // Lista a turma inserida
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listAlunos.ItemsSource = null;
            listAlunos.ItemsSource = NAluno.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Aluno t = new Aluno();
            t.Id = int.Parse(txtId.Text);
            t.Nome = txtNome.Text;
            t.Matricula = txtMatricula.Text;
            t.Email = txtEmail.Text;
            // Inserir a turma na lista de turmas
            NAluno.Atualizar(t);
            // Lista as turmas cadastradas
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Aluno t = new Aluno();
            t.Id = int.Parse(txtId.Text);
            // Inserir a turma na lista de turmas
            NAluno.Excluir(t);
            // Lista as turmas cadastradas
            ListarClick(sender, e);
        }

        private void listAlunos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                Aluno obj = (Aluno)listAlunos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtMatricula.Text = obj.Matricula;
                txtEmail.Text = obj.Email;
            }
        }
    }
}
