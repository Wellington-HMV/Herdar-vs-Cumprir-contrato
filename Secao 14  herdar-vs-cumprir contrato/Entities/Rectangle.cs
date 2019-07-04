using System;
using System.Globalization;
using Entities;

namespace Entities
{
    class Rectangle:AbstractShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }
        public override double Area()
        {
            return Width * Heigth;
        }
        public override string ToString()
        {
            return "Rectangle color = " 
                + Color + " Width: " 
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", heigth= " 
                + Heigth.ToString("F2", CultureInfo.InvariantCulture) 
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
