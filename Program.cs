using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Insira o valor do primeiro lado do primeiro triangulo:");
            triangulo.x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo lado do primeiro triangulo:");
            triangulo.x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do terceiro lado do primeiro triangulo:");
            triangulo.x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do primeiro lado do segundo triangulo:");
            triangulo.y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo lado do segundo triangulo:");
            triangulo.y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do terceiro lado do segundo triangulo:");
            triangulo.y3 = int.Parse(Console.ReadLine());
            Area(triangulo.x1, triangulo.x2, triangulo.x3, triangulo.y1, triangulo.y2, triangulo.y3);
        }
        static void Area(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            double semi1 = (x1 + x2 + x3) / 2.0;
            double semi2 = (y1 + y2 + y3) / 2.0;
            double temp1 = semi1 * (semi1 - x1) * (semi1 - x2) * (semi1 - x3);
            double area1 = Math.Sqrt(temp1);
            double temp2 = semi2 * (semi2 - y1) * (semi2 - y2) * (semi2 - y3);
            double area2 = Math.Sqrt(temp2);
            if (area1 > area2)
            {
                Console.WriteLine("O primeiro triângulo apresenta maior área.");
            }
            else if (area2 > area1)
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
