namespace Triangulos.Entities
{
    abstract class Triangulo
    {
        public virtual double CatetoA { get; protected set; }
        public double CatetoB { get; protected set; }
        public double Hipotenusa { get; protected set; }
     
        public Triangulo()
        {

        }
        
        public Triangulo(double catetoA, double catetoB, double hipotenusa)
        {
            CatetoA = catetoA;
            CatetoB = catetoB;
            if (hipotenusa == 0)
            {
                Hipotenusa = CalcularHipotenusa();
            }
            else
            {
                Hipotenusa = hipotenusa;
            }
        }

        public double CalcularHipotenusa()
        {
            double SomaDosLadosCatetos = Math.Pow(CatetoA, 2) + Math.Pow(CatetoB, 2);
            return Math.Sqrt(SomaDosLadosCatetos);
        }

        abstract protected double CalArea();

        public double CalcPerimetro() => CatetoA + CatetoB + Hipotenusa;



    }
}
