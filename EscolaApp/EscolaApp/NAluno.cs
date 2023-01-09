using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    class NAluno
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public static void Inserir(Aluno a)
        {
            Abrir();
            alunos.Add(a);
            Salvar();
        }
        public static List<Aluno> Listar()
        {
            Abrir();
            return alunos;
        }
        public static void Atualizar(Aluno a)
        {
            Abrir();
            foreach (Aluno obj in alunos)
                if (obj.Id == a.Id)
                {
                    obj.Nome = a.Nome;
                    obj.Matricula = a.Matricula;
                    obj.Email = a.Email;
                }
            Salvar();
        }
        public static void Excluir(Aluno a)
        {
            Abrir();
            Aluno x = null;
            foreach (Aluno obj in alunos)
                if (obj.Id == a.Id) x = obj;
            if (x != null) alunos.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
                f = new StreamReader("./alunos.xml");
                alunos = (List<Aluno>)xml.Deserialize(f);
            }
            catch
            {
                alunos = new List<Aluno>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
            StreamWriter f = new StreamWriter("./alunos.xml", false);
            xml.Serialize(f, alunos);
            f.Close();
        }
    }
}
