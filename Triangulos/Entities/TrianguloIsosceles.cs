namespace Triangulos.Entities
{
    class TrianguloIsosceles : Triangulo
    {
        
        public TrianguloIsosceles(double catetoA, double catetoB) : base(catetoA, catetoB)
        {

        }
        public TrianguloIsosceles(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }
        public override double CalArea()
        {
            if (CatetoA == CatetoB)
            {
                return Math.Sqrt(Math.Pow(CatetoA, 2) - (Math.Pow(Hipotenusa, 2) / 4));
            }
            if (CatetoA == Hipotenusa)
            {
                return Math.Sqrt(Math.Pow(CatetoA, 2) - (Math.Pow(Hipotenusa, 2) / 4));
            }
            else
            {
                return Math.Sqrt(Math.Pow(CatetoB, 2) - (Math.Pow(Hipotenusa, 2) / 4));
            }
        }

    }
}
