using System;
using System.Collections.Generic;
using System.Text;

namespace Heron
{
    public class Triangulo
    {
        public int A;
        public int B;
        public int C;
        public double area;
        public void calculoArea()
        {
            double p = (A + B + C) / 2.0;
            area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
