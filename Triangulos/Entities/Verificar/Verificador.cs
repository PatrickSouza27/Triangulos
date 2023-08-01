namespace Triangulos.Entities
{
    class Verificador : Triangulo
    {
        public Verificador()
        {
        }

        public Verificador(double catetoA, double catetoB, double hipotenusa) : base(catetoA, catetoB, hipotenusa)
        {

        }

        public bool ValidaTrianguloRetangulo() => Math.Round(Math.Pow(Hipotenusa, 2)) == Math.Round(Math.Pow(CatetoA, 2) + Math.Pow(CatetoB, 2));
        public bool ValidaIsosceles() => (CatetoA == CatetoB) || (CatetoB == Hipotenusa) || (Hipotenusa == CatetoA);

        public bool ValidaEquilatero() => (CatetoA == CatetoB) && (CatetoB == Hipotenusa);

        


        protected override double CalArea() => 0;
        

    }
}
