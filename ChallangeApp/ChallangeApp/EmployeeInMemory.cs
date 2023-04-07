
using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace ChallangeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelagate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("value is valid");
            }
        }

        public override void AddGrades(double grade)
        {
            grade = Math.Round(grade, 2);
            this.AddGrades((float)grade);
        }
        public override void AddGrades(int grade)
        {
            this.AddGrades((float)grade);
        }
        public override void AddGrades(char grade)
        {

            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrades(100);
                    break; ;
                case 'B':
                case 'b':
                    this.AddGrades(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrades(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrades(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrades(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else if (char.TryParse(grade, out char charToString))
            {
                this.AddGrades(charToString);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrades(grade);
            }
            return statistics;
        }
    }
}
