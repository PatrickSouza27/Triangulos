namespace Triangulos.Entities
{
    public class Triangulo
    {
        public virtual double CatetoA { get; protected set; }
        public double CatetoB { get; protected set; }
        public double Hipotenusa { get; protected set; }
     
        public Triangulo()
        {

        }
        public Triangulo(double catetoA, double catetoB)
        {
            CatetoA = catetoA;
            CatetoB = catetoB;
            Hipotenusa = CalcularHipotenusa();
        }
        public Triangulo(double catetoA, double catetoB, double hipotenusa)
        {
            CatetoA = catetoA;
            CatetoB = catetoB;
            Hipotenusa = hipotenusa;
        }

        public double CalcularHipotenusa()
        {
            double SomaDosLadosCatetos = Math.Pow(CatetoA, 2) + Math.Pow(CatetoB, 2);
            return Math.Sqrt(SomaDosLadosCatetos);
        }

        public bool ValidaEscaleno() => CatetoA != CatetoB && CatetoB != Hipotenusa && Hipotenusa != CatetoA;

        public bool ValidaIsosceles() => CatetoA == CatetoB || CatetoB == Hipotenusa || Hipotenusa == CatetoA;

        public bool ValidaEquilatero() => CatetoA == CatetoB && CatetoB == Hipotenusa && Hipotenusa == CatetoA;

        public bool ValidarTrianguloRetangulo() => Math.Round(Math.Pow(CatetoA, 2) + Math.Pow(CatetoB, 2)) == Math.Round(Math.Pow(Hipotenusa, 2));

        public virtual double CalArea() => 0;

        public double CalcPerimetro() => CatetoA + CatetoB + Hipotenusa;



    }
}
