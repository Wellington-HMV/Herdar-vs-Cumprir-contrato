using System;
using System.Globalization;
using Entities;

namespace Secao_14__herdar_vs_cumprir_contrato
{
    class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }
        public override double Area()
        {
            return Width * Heigth;
        }
        public override string ToString()
        {
            return "Rectangle color = " + Color + " Width: " + Width.ToString("F2", CultureInfo.InstalledUICulture)
                + ", heigth= " + Heigth.ToString("F2", CultureInfo.InstalledUICulture) + Area().ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}
