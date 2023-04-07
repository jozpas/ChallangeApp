
using static ChallangeApp.EmployeeBase;

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrades(float grade);
        void AddGrades(double grade);
        void AddGrades(int grade);
        void AddGrades(char grade);
        void AddGrades(string grade);

        event GradeAddedDelagate GradeAdded;
        Statistics GetStatistics();
    }
}
