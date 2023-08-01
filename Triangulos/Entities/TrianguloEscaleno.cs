using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.Entities
{
    class TrianguloEscaleno : Triangulo
    {
        
        public TrianguloEscaleno(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }
        protected override double CalArea()
        {
            double p = CalcPerimetro() / 2;
            return p * (p - CatetoA) * (p - CatetoB) * (p - Hipotenusa);
        }
        public override string ToString()
        {
            return ($"Triangulo Escaleno\nÁrea: {CalArea().ToString("f3")}\nPerimetro: {CalcPerimetro()}");
        }

    }
}
