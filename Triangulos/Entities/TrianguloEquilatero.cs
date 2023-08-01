namespace Triangulos.Entities
{
    class TrianguloEquilatero : Triangulo
    {


        public TrianguloEquilatero(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }
        protected override double CalArea() => (CatetoA * Math.Sqrt(3) / 2 * CatetoA) / 2;

        public override string ToString()
        {
            return ($"Triangulo Equilatero\nÁrea: {CalArea().ToString("f3")}\nPerimetro: {CalcPerimetro()}");
        }
    }
}
