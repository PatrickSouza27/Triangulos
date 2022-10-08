namespace Triangulos.Entities
{
    class TrianguloRetangulo : Triangulo
    {
        
        public TrianguloRetangulo(double catetoA, double catetoB):base(catetoA, catetoB)
        {

        }
        public TrianguloRetangulo(double catetoA, double catetoB, double hipotenusa):base(catetoA, catetoB, hipotenusa)
        {

        }
        public override double CalArea() => CatetoA * CatetoB / 2;

  

    }
}
