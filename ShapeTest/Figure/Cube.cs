using System;
namespace ShapeTest
{
    public class Cube : Figure
    {
      
        public double x{get;set;}
        public double y{get;set;}
        public string name{get;set;}

        public Cube(double theX, double theY, string name) : base(x, y, name)
        {
            name = name;
            x = theX;
            y = theY;
        }

        public override double Area()
        {
            return ((theX * theY) * 6);
        }

        
        public override void GetInfo()
        {
            
            base.GetInfo();
            Console.WriteLine($"It has a Length of {theX} and Lenght of {theY}");
        }
    }
}
