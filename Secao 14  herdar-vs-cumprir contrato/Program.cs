using System;
using Entities;
using Enums;

namespace Secao_14__herdar_vs_cumprir_contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle { Radius = 2.0, Color = Color.White };
            Shape s2 = new Rectangle { Width = 3.5, Heigth = 4.2,Color = Color.White };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
