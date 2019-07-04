using System;
using Enums;

namespace Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
