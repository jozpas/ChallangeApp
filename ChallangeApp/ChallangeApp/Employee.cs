﻿
namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }



        //3.33
        //3
        //int valueInInt = (int)grade;//to odina to co jest po przecinku !NIE ZAOKRĄGLA!//
        // int valueInInt = Math.Ceiling(grade); // zokrągla do góry
        //int valueInInt = Math.Floor(grade); // zokrągla w dół


        public void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"value: {grade} is invalid");
            }
        }

        public void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                Console.WriteLine($"string: {grade} is not float");
            }
        }

        public void AddGrades(double grade)
        {
            grade = Math.Round(grade, 2);
            this.AddGrades((float)grade);
        }
        public void AddGrades(long grade)
        {
            this.AddGrades(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (this.grades.Count > 0)
            {

                foreach (var grade in this.grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                // statistics.Average = statistics.Average / this.grades.Count;
                statistics.Average /= this.grades.Count;

            }
            else
            {
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.Average = 0;
            }
            return statistics;
        }

    }


}
