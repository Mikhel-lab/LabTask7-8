using System;
namespace ShapeTest
{
    public class Cube : Figure
    {
      
        public double X{get;set;}
        public double Y{get;set;}
        public string Name{get;set;}

        public Cube(double theX, double theY, string name) : base(theX, theY, name)
        {
            Name = name;
            X = theX;
            Y = theY;
        }

        public override double Area()
        {
            return ((X * Y) * 6);
        }

        
        public override void GetInfo()
        {
            Area();
            base.GetInfo();
            Console.WriteLine($"It has a Length of {X} and Lenght of {Y}");
        }
    }
}
