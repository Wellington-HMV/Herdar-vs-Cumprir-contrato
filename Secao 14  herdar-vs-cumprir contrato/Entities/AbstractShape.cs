﻿using System;
using Enums;

namespace Entities
{
    abstract class AbstractShape:IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
