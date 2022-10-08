namespace Triangulos.Entities
{
    class TrianguloEquilatero : Triangulo
    {
        
        public TrianguloEquilatero(double catetoA, double catetoB) : base(catetoA, catetoB)
        {

        }
        public TrianguloEquilatero(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }
        public override double CalArea() => (Math.Pow(CatetoA, 2) + Math.Sqrt(3)) / 4;
        
             
    }
}
