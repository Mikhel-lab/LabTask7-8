

using System;
namespace ShapeTest
{
    public class Figure
    {
       public double X{get;set;}
        public double Y{get;set;}
        public string Name{get;set;}

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        public Figure(double theX, double theY, string name)
        {
            X = theX;
            Y = theY;
            Name = name;
        }

        public virtual double Area()
        {
            
        }
       
    }
}
