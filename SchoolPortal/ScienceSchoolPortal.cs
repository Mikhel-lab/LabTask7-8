using System;
namespace SchoolPortal
{
    public class ScienceSchoolPortal : Student
    {
        private string Science{get;set;}
        private int Mark;
        private string SCI;

         public ScienceSchoolPortal(int reg, string name, int score, string science, int mark, string sci) : base(reg, name, score)
        {
            Science = science;
            Mark = mark;
            SCI = sci;
        }

        public int mark
        {
            get{return mark;}
            set
            {
                if((value == ComputerNetwork) && (value == DataStructure) && (value == C-Sharp))
            {
                SCI = value;
            }else {
                    throw new System.ArgumentOutOfRangeException("Out of range of SCI");
                }
            }
        }

         public double AverageMark1()
        {
            return (ComputerNetwork + DataStructure + C-Sharp) / 3;
        }

          public override string ToString()
        {
            return $"School Portal Type : Science\n{ RegNumber}, {Name},\nScience:{Science}\nMark:{Mark}\nSCI:{SCI} ";
        }
    }
}