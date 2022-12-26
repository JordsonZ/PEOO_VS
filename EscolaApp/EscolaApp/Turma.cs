﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    class Turma
    {
        public int Id { get; set; }
        public string Curso { get; set; }
        public string Descricao { get; set; }
        public int AnoLetivo { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Curso} - {Descricao} - {AnoLetivo}";
        }
    }
}
