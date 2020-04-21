using System;
namespace ShapeTest
{
    public class Rectangle : Figure
    {
      
        public double x{get;set;}
        public double y{get;set;}
        public string name{get;set;}

        public Rectangle(double theX, double theY, string name) : base(x, y, name)
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
            Console.WriteLine($"It has a Length of {theX} and Width of {theY}");
        }
    }
}
