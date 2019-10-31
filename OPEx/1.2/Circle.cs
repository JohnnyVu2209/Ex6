using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Circle
    {
        private double radius;
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return this.radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetCircumference()
        {
            return (radius*2)* Math.PI;
        }
        //overload
        public override string ToString()
        {
            return "Cicle[radius]";
        }
    }
}
