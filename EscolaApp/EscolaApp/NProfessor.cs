using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    class NProfessor
    {
        private static List<Professor> profs = new List<Professor>();
        public static void Inserir(Professor p)
        {
            Abrir();
            int id = 0;
            foreach (Professor obj in profs)
                if (obj.Id > id) id = obj.Id;
            p.Id = id + 1;
            profs.Add(p);
            Salvar();
        }
        public static List<Professor> Listar()
        {
            Abrir();
            return profs;
        }
        public static void Excluir(Professor p)
        {
            Abrir();
            Professor x = null;
            foreach (Professor obj in profs)
                if (obj.Id == p.Id) x = obj;
            if (x != null) profs.Remove(x);
            Salvar();
        }
        public static void Atualizar(Professor p)
        {
            Abrir();
            foreach (Professor obj in profs)
                if (obj.Id == p.Id)
                {
                    obj.Nome = p.Nome;
                    obj.Matricula = p.Matricula;
                    obj.Area = p.Area;
                }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
                f = new StreamReader("./profs.xml");
                profs = (List<Professor>)xml.Deserialize(f);
            }
            catch
            {
                profs = new List<Professor>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
            StreamWriter f = new StreamWriter("./profs.xml", false);
            xml.Serialize(f, profs);
            f.Close();
        }
    }
}
