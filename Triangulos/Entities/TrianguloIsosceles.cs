namespace Triangulos.Entities
{
    class TrianguloIsosceles : Triangulo
    {

        public TrianguloIsosceles(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }
        protected override double CalArea()
        {
            if (CatetoA == CatetoB)
            {
                return (Hipotenusa * Math.Sqrt(Math.Pow(CatetoA, 2) - (Math.Pow(Hipotenusa, 2) / 4))) / 2;
            }
            if (CatetoA == Hipotenusa)
            {
                return (Hipotenusa * Math.Sqrt(Math.Pow(CatetoA, 2) - (Math.Pow(Hipotenusa, 2) / 4))) / 2;
            }
            else
            {
                return (Hipotenusa * Math.Sqrt(Math.Pow(CatetoB, 2) - (Math.Pow(Hipotenusa, 2) / 4))) / 2;
            }
        }
        public override string ToString()
        {
            return ($"Triangulo Isosceles\nÁrea: {CalArea().ToString("F3")}\nParametro:{CalcPerimetro().ToString()}");
        }

    }
}
