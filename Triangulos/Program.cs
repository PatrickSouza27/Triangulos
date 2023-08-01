using System;
using Triangulos.Entities;

namespace Principal
{
    class Program
    {
        static void Main()
        {
            Triangulo triangulo;
            Console.WriteLine("Primeiro Lado: ");
            double L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Lado: ");
            double L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Base          //Caso você não saiba, digite 0: ");
            double Base = double.Parse(Console.ReadLine());
            Verificador x = new Verificador(L1, L2, Base);
            if (x.ValidaIsosceles())
            {
                triangulo = new TrianguloIsosceles(L1, L2, Base);
            }
            else if (x.ValidaTrianguloRetangulo())
            {
                triangulo = new TrianguloRetangulo(L1, L2, Base);
            }
            else if (x.ValidaEquilatero())
            {
                triangulo = new TrianguloEquilatero(L1, L2, Base);
            }
            else
            {
                triangulo = new TrianguloEscaleno(L1, L2, Base);
            }
            Console.WriteLine(triangulo);
        }
    }
}
