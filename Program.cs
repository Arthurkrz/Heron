using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            Triangulo t2 = new Triangulo();
            Console.WriteLine("Insira o valor dos lados do primeiro triangulo sequencialmente:");
            t1.A = int.Parse(Console.ReadLine());
            t1.B = int.Parse(Console.ReadLine());
            t1.C = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor dos lados do segundo triangulo sequencialmente:");
            t2.A = int.Parse(Console.ReadLine());
            t2.B = int.Parse(Console.ReadLine());
            t2.C = int.Parse(Console.ReadLine());
            t1.calculoArea();
            t2.calculoArea();
            if (t1.area > t2.area)
            {
                Console.WriteLine("O primeiro triângulo apresenta maior área.");
            }
            else if (t2.area > t1.area)
            {
                Console.WriteLine("O segundo triângulo apresenta maior área.");
            }
            else
            {
                Console.WriteLine("Os triângulos apresentam a mesma área.");
            }
        }
    }
}
