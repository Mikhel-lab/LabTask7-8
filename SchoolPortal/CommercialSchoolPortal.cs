using System;
namespace SchoolPortal
{
    public class CommercialSchoolPortal : Student
    {
        private string Commercial{get;set;}
        private int Mark;
        private string COM;

         public CommercialSchoolPortal(int reg, string name, int score, string commercial, int mark, string com) : base (reg, name, score)
        {
            Commercial = commercial;
            Mark = mark;
            COM = com;
        }

        public int mark
        {
            get{return mark;}
            set
            {
                if((value == ElectronicCircute) && (value == CircuteAnalysis) && (value == AnalogCommunication))
            {
                COM = value;
            }else {
                    throw new System.ArgumentOutOfRangeException("Out of range of COM");
                }
            }
        }

        public double AverageMark2()
        {
            return (ElectronicCircute + CircuteAnalysis + AnalogCommunication) / 3;
        }

          public override string ToString()
        {
            return $"School Portal Type : Science\n{ RegNumber}, {Name},\nCommercial:{Commercial}\nMark:{Mark}\nCOM:{COM} ";
        }


    }
}