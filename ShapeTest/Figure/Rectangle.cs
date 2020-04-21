using System;
namespace ShapeTest
{
    public class Rectangle : Figure
    {
      
       public double X{get;set;}
        public double Y{get;set;}
        public string Name{get;set;}

        public Rectangle(double theX, double theY, string name) : base(theX, theY, name)
        {
            Name = name;
            X = theX;
            Y = theY;
        }

        public override double Area()
        {
            return X * Y;
        }

        
        public override void GetInfo()
        {
            
            base.GetInfo();
            Console.WriteLine($"It has a Length of {X} and Width of {Y}");
        }
    }
}
