using System;
namespace ShapeTest
{
    public class Triangle :Figure
    {
     

        public Triangle(double theX, double theY, string name) : base(theX, theY, name)
        {
            Name = name;
            X = theX;
            Y = theY;
        }


        public override double Area()
        {
            return X * (Y / 2);
        }

        
        public override void GetInfo()
        {
            
            base.GetInfo();
            Console.WriteLine($"It has the base of {X} and height of {Y}");
        }
    }
}
