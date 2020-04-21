using System;
namespace ShapeTest
{
    public class Square : Figure
    {
        public double x{get;set;}
        public double y{get;set;}
        public string name{get;set;}

        public Square(double theX, double theY, string name) : base(x, y, name)
        {
            name = name;
            x = theX;
            y = theY;
        }


        public override double Area()
        {
            return theX * theY;
        }

        
        public override void GetInfo()
        {
            
            base.GetInfo();
            Console.WriteLine($"It has the Lenght of {theX} and Width of {theY}");
        }
    }
}
