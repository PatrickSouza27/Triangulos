using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.Entities
{
    class TrianguloEscaleno : Triangulo
    {
        
        public TrianguloEscaleno(double catetoA, double catetoB) : base(catetoA, catetoB)
        {

        }
        public TrianguloEscaleno(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }
        public override double CalArea()
        {
            double p = CatetoA + CatetoB + Hipotenusa;
            return Math.Sqrt(p * (p - CatetoA) * (p - CatetoB) * (p - Hipotenusa));
        }

        
    }
}
