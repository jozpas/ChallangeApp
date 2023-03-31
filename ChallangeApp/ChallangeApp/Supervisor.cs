
namespace ChallangeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor() { }
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrades(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrades(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrades(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrades(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrades(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case var a when (a == "-6" || a == "6-"):
                    this.grades.Add(95);
                    break;

                case "5":
                    this.grades.Add(80);
                    break;
                case var a when (a == "+5" || a == "5+"):
                    this.grades.Add(85);
                    break;
                case var a when (a == "-5" || a == "5-"):
                    this.grades.Add(75);
                    break;

                case "4":
                    this.grades.Add(60);
                    break;
                case var a when (a == "+4" || a == "4+"):
                    this.grades.Add(65);
                    break;
                case var a when (a == "-4" || a == "4-"):
                    this.grades.Add(55);
                    break;

                case "3":
                    this.grades.Add(40);
                    break;
                case var a when (a == "+3" || a == "3+"):
                    this.grades.Add(45);
                    break;
                case var a when (a == "-3" || a == "3-"):
                    this.grades.Add(35);
                    break;

                case "2":
                    this.grades.Add(20);
                    break;
                case var a when (a == "+2" || a == "2+"):
                    this.grades.Add(25);
                    break;
                case var a when (a == "-2" || a == "2-"):
                    this.grades.Add(15);
                    break;

                case "1":
                    this.grades.Add(0);
                    break;

            }
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
                statistics.Average /= this.grades.Count;

            }
            else
            {
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.Average = 0;
            }

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
