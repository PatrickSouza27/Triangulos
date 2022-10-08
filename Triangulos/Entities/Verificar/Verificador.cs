namespace Triangulos.Entities
{
    class Verificador : Triangulo
    {
        public Verificador(double catetoA, double catetoB) : base(catetoA, catetoB)
        {

        }
        public Verificador(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }
        public bool ValidaEscaleno() => CatetoA != CatetoB && CatetoB != Hipotenusa && Hipotenusa != CatetoA;

        public bool ValidaIsosceles() => CatetoA == CatetoB || CatetoB == Hipotenusa || Hipotenusa == CatetoA;

        public bool ValidaEquilatero() => CatetoA == CatetoB && CatetoB == Hipotenusa && Hipotenusa == CatetoA;

        public bool ValidarTrianguloRetangulo() => Math.Round(Math.Pow(CatetoA, 2) + Math.Pow(CatetoB, 2)) == Math.Round(Math.Pow(Hipotenusa, 2));
    }
}
