
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
            this.grades.Add(grade);
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
