using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShapes;

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}
