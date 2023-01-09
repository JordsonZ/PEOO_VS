using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Matricula} - {Email}";
        }
    }
}
