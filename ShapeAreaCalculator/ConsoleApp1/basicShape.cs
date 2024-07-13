using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class basicShape
    {
        public virtual double sideNum { get; protected set; }
        public double sideLength {  get; set; }

        public basicShape()
        {
            sideNum = 0;
            sideLength = 0;
        }

        public basicShape(double sideNum, double sideLength)
        {
            this.sideNum = sideNum;
            this.sideLength = sideLength;
        }
        public double Perimitter ()
        {
            return sideLength * sideNum;
        }

        public virtual double Area()
        {
            return sideLength * sideNum;
        }
    }

    public class Triangle : basicShape
    {
        public double height;
        public Triangle()
        {
            sideNum = 3;
            sideLength = 0;
            height = 0;
        }

        public Triangle(double sideLength, double height)
        {
            sideNum = 3;
            this.sideLength = sideLength;
            this.height = height;
        }

        public override double Area()
        {
            return sideLength * height / 2;
        }

    }

    public class Square: basicShape
    {
        public Square()
        {
            sideNum = 4;
            sideLength = 0;
        }

        public Square(double sideLength)
        {
            sideNum = 4;
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return sideLength * sideLength;
        }
    }
    
}
