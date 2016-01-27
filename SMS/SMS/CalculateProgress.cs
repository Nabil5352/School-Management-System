using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class CalculateProgress
    {
        public int progressValue { get; set; }
        public int progressPercentage { get; set; }

        public int SingleSubjectCalculation(int totalStudent, int firstGrade, int secondGrade, int thirdGrade, int otherGrade)
        {
            int firstGradeNumber = 40;
            int secondGradeNumber = 30;
            int thirdGradeNumber = 20;
            int otherGradeNumber = 10;

            int GetFirstGrade = (firstGrade * firstGradeNumber)/totalStudent;
            int GetSecondGrade = (secondGrade * secondGradeNumber) / totalStudent;
            int GetThirdGrade = (thirdGrade * thirdGradeNumber) / totalStudent;
            int GetOtherGrade = (otherGrade * otherGradeNumber) / totalStudent;

            progressValue = GetFirstGrade + GetSecondGrade + GetThirdGrade + GetOtherGrade;

            return progressValue;
        }

        public int AllSubjectCalculation(int noOfSubject, int totalPoint)
        {
            int subjectValue = noOfSubject * 100;
            progressPercentage = (totalPoint * 100) / subjectValue;
            return progressPercentage;
        }       
    }
}
