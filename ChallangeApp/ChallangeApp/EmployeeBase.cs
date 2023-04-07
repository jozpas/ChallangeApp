namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {

        public delegate void GradeAddedDelagate(object sender, EventArgs args);

        public abstract event GradeAddedDelagate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
               
        public string Name { get; private set; }
        public string Surname { get; private set; }

       
        public abstract void AddGrades(float grade);

        public abstract void AddGrades(double grade);

        public abstract void AddGrades(int grade);

        public abstract void AddGrades(char grade);

        public abstract void AddGrades(string grade);

        public abstract Statistics GetStatistics();

    }
}
