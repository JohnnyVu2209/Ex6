using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Rectangle
    {
        private float lenght;
        private float width;
        public Rectangle()
        {
            lenght = 1.0f;
            width = 1.0f;
        }
        public Rectangle(float lenght , float width)
        {
            this.lenght = lenght;
            this.width = width;
        }
        public float GetLenght()
        {
            return this.lenght;
        }
        public void SetLenght(float Lenght)
        {
            this.lenght = Lenght;
        }
        public float GetWidth()
        {
            return this.width;
        }
        public void SetWidth(float Width)
        {
            this.width = Width;
        }
        public double GetArea()
        {
            return lenght * width;
        }
        public double GetPerimeter()
        {
            return (lenght + width)*2;
        }
        public override string ToString()
        {
            return String.Format("Rectangle[{0},{1}]", lenght, width);
        }
    }
}
