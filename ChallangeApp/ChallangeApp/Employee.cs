
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
        public void AddGrades(int grade)
        {
            this.AddGrades((float)grade);
        }

        public Statistics GetStatisticsWithForeach()
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

        public Statistics GetStatisticWithFor()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics1.Max = Math.Max(statistics1.Max, this.grades[i]);
                statistics1.Min = Math.Min(statistics1.Min, this.grades[i]);
                statistics1.Average += this.grades[i];
            }
            statistics1.Average /= this.grades.Count;
            return statistics1;
        }
        public Statistics GetStatisticWithDoWhile()
        {
            var index = 0;
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Min = float.MaxValue;
            statistics2.Max = float.MinValue;

            do
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index]);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[index]);
                statistics2.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistics2.Average /= this.grades.Count;
            return statistics2;
        }
        public Statistics GetStatisticWithWhile()
        {
            var index = 0;
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;   
            
            while( index < this.grades.Count)
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Average += this.grades[index];
                index++;
            }
            statistics3.Average /= this.grades.Count;
            return statistics3;
        }

    }


}
