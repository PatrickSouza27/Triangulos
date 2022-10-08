using System;
using Triangulos.Entities;

namespace Principal
{
    class Program
    {
        static void Main()
        {
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Primeiro Lado: ");
            double L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Lado: ");
            double L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Base: ");
            double Base = double.Parse(Console.ReadLine());
            if (triangulo.ValidaEquilatero())
            {
                
            }
        }
    }
}
