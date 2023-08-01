namespace Triangulos.Entities
{
    class TrianguloRetangulo : Triangulo
    {

        public TrianguloRetangulo(double catetoA, double catetoB, double hipotenusa):base(catetoA, catetoB, hipotenusa)
        {

        }
        private double CalcAltura() => CatetoA * CatetoB / Hipotenusa;
        protected override double CalArea() => CatetoA * CatetoB / 2;
        

        public override string ToString()
        {
            return ($"Triangulo Retangulo\nÁrea:{CalArea().ToString("F3")}\nAltura Computing: {CalcAltura()}\nPerimetro: {CalcPerimetro()}");
        }

    }
}
