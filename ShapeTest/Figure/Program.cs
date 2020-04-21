using System;

namespace ShapeTest
{
    class Program
    {    
        static void Main(string[] args)
        {
            
           
            Rectangle rec = new Rectangle(4,5, "rectangle");
            Triangle tri = new Triangle(5,3, "triangle");
            Square sql = new Square(3,2, "square");
            Cube cb = new Cube(6,4, "cube");
            rec.Area();
            tri.Area();
            sql.Area();
            cb.Area();
            Console.WriteLine(rec.Area());
            Console.WriteLine(tri.Area());
            Console.WriteLine(sql.Area());
            Console.WriteLine(cb.Area());
            


        }
        
    }

}

