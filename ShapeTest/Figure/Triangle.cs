using System;
namespace ShapeTest
{
    public class Triangle :Figure
    {
        public double x{get;set;}
        public double y{get;set;}
        public string name{get;set;}

        public Triangle(double theX, double theY, string name) : base(x, y, name)
        {
            name = name;
            x = theX;
            y = theY;
        }


        public override double Area()
        {
            return theX * (theY / 2);
        }

        
        public override void GetInfo()
        {
            
            base.GetInfo();
            Console.WriteLine($"It has the base of {theX} and height of {theY}");
        }
    }
}
