using System;
namespace SchoolPortal
{
    public class Student
    {
        public int RegNumber{get;set;}
        public string Name{get;set;}
        public int Scores{get;set;}

        
        public void Students(int reg, string name, int score)
        {
            RegNumber = reg;
            Name = name;
            Scores = score;
        }
    }
}