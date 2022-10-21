using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloApp
{
    class Retangulo
    {
        private double b, h;

        public void SetBase(double v)
        {
            if (v > 0) b = v;
        }
        public void SetAltura(double v)
        {
            if (v > 0) h = v;
        }
        public double GetBase() => b;
        public double GetAltura() => h;
        public double CalcArea() => b * h;
        public double CalDiagonal() => Math.Sqrt(b * b + h * h);
    }
}
