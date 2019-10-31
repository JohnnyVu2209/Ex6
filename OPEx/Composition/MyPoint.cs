using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class MyPoint
    {
        private int X, Y;
        int[] xy = new int[2];
        public MyPoint()
        {
            this.X = this.Y = 0;
        }
        public MyPoint(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int GSX
        {
            get
            {
                return this.X;
            }
            set
            {
                this.X =value;
            }
        }
        public int GSY
        {
            get
            {
                return this.Y;
            }
            set
            {
                this.Y = value;
            }
        }
        public int[] GetXY()
        {
           return (new int[]{this.X , this.Y});
        }
        public void SetXY(int x, int Y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return String.Format("({0},{1})",this.X,this.Y);
        }
        public double Distance(int x ,int y)
        {
            return Math.Sqrt(Math.Pow(this.X - x,2) + Math.Pow(this.Y-y,2));
        }
        public double Distance(MyPoint another)
        {
            return Distance(another.GSX, another.GSY);
        }
        public double Distance()
        {
            return Distance(0, 0);
        }
    }
}
