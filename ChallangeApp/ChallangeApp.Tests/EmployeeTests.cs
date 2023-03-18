namespace ChallangeApp.Tests
{
    public class Tests
    {

        [Test]
        public void CheckMaxGradeFromAllGrades()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrades(5.5f);
            employee.AddGrades(6.74f);
            employee.AddGrades(4.01f);

            // act
            var max = employee.GetStatistics().Max;

            // assert
            Assert.AreEqual(6.74f, max);

        }

        [Test]
        public void CheckMinGradeFromAllGrades()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrades(5.5f);
            employee.AddGrades(6.74f);
            employee.AddGrades(4.01f);

            // act
            var min = employee.GetStatistics().Min;

            // assert
            Assert.AreEqual(4.01f, min);

        }
        [Test]
        public void CheckAvargeGradeFromAllGrades()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrades(5.5f);
            employee.AddGrades(6);
            employee.AddGrades(5);

            // act
            var avg = employee.GetStatistics().Average;

            // assert
            Assert.AreEqual(5.5f, avg);

        }
        [Test]
        public void CheckTwoEmployeesAreDiffrent()
        {
            // arrange
            var employee1 = new Employee("Jan", "Kowalski");
            var employee2 = new Employee("Janek", "Kowalewski");

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);

        }
    }
}