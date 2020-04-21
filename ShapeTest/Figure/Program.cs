using System;

namespace ShapeTest
{
    class Program
    {    
        static void Main(string[] args)
        {
            
            // Figure[] shapes = {new Triangle(5,3),
            // new Rectangle(4,5), new Square(3,2), new Cube(6,4)};
            Rectangle rec = new Rectangle(4,5, "rectangle");
            Triangle tri = new Triangle(5,3, "triangle");
            Square sql = new Square(3,2, "square");
            Cube cb = new Cube(6,4, "cube");
            rec.Area();
            tri.Area();
            sql.Area();
            cb.Area();
            

           
       

        }
        
    }

}
