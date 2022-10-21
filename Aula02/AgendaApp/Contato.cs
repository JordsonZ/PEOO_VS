using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp
{
    class Contato
    {
        private string nome, email, fone;
        public Contato(string n, string e, string f)
        {
            nome = n;
            email = e;
            fone = f;
        }
        public override string ToString()
        {
            return $"{nome} - {email} - {fone}";
        }
    }
}
