
namespace ChallangeApp
{
    public class Employee
    {
        //string name;
        //string surname;
        //int age;
        List<int> score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = 0;
        }
        public Employee(string name)
        {
            this.Name = name;
            this.Surname = "null";
        }

        public Employee()
        {
            
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Rating
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);

        }
    }
}
