using System;

namespace Figure
{
    class Program
    {    
        static void Main(string[] args)
        {
            
            Figure[] shapes = {new Triangle(5,3),
            new Rectangle(4,5), new Square(3,2), new Cube(6,4)};

           
            foreach(shape s in Figure)
            {
                
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}",
                s.Name, s.Area());
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        
    }

}

