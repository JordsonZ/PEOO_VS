using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastecimentoApp
{
    class Abastecimento
    {
        private double valorLt, valorPg, KmRodados;

        public void SetValorLt(double valorLt)
        {
            if (valorLt > 0) this.valorLt = valorLt;
        }
        public void SetValorPg(double valorPg)
        {
            if (valorPg > 0) this.valorPg = valorPg;
        }
        public void SetKmRodados(double KmRodados)
        {
            if (KmRodados > 0) this.KmRodados = KmRodados;
        }
        public double MediaKmLitro()
        {
            double numLitros = valorPg / valorLt;
            return KmRodados / numLitros;
        }
        public double MediaReaisKm()
        {
            return valorPg / KmRodados;
        }
    }
    
}
