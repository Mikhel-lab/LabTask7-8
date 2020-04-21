
using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Student portal = new Student();
            Console.WriteLine("Please enter your Name: ");
           string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your registration number: ");
             int reg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your department: ");
             string dep = Convert.ToString(Console.ReadLine());
            portal.AverageMark1();
            portal.AverageMark2();

        }
    }
}
