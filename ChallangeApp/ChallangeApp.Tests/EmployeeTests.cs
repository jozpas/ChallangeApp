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

        [Test]
        public void CheckGradeInLetter()
        {
            //arrange
            var employee1 = new Employee();
            var employee2 = new Employee();
            var employee3 = new Employee();
            var employee4 = new Employee();
            var employee5 = new Employee();
            employee1.AddGrades('A');
            employee2.AddGrades('B');
            employee3.AddGrades('C');
            employee4.AddGrades('D');
            employee5.AddGrades('E');

            //act
            var value1 = employee1.GetStatistics().Min;
            var value2 = employee2.GetStatistics().Min;
            var value3 = employee3.GetStatistics().Min;
            var value4 = employee4.GetStatistics().Min;
            var value5 = employee5.GetStatistics().Min;

            //asery
            Assert.AreEqual(100, value1);
            Assert.AreEqual(80, value2);
            Assert.AreEqual(60, value3);
            Assert.AreEqual(40, value4);
            Assert.AreEqual(20, value5);
        }

        [Test]
        public void CheckAveregeInLetter()
        {
            //arrange
            var employee1 = new Employee();
            employee1.AddGrades(93);
            employee1.AddGrades(97);
            var employee2 = new Employee();
            employee2.AddGrades(73);
            employee2.AddGrades(77);
            var employee3 = new Employee();
            employee3.AddGrades(53);
            employee3.AddGrades(57);
            var employee4 = new Employee();
            employee4.AddGrades(33);
            employee4.AddGrades(37);
            var employee5 = new Employee();
            employee5.AddGrades(13);
            employee5.AddGrades(17);

            //act
            var averege1 = employee1.GetStatistics().AverageLetter;
            var averege2 = employee2.GetStatistics().AverageLetter;
            var averege3 = employee3.GetStatistics().AverageLetter;
            var averege4 = employee4.GetStatistics().AverageLetter;
            var averege5 = employee5.GetStatistics().AverageLetter;

            //asery
            Assert.AreEqual('A', averege1);
            Assert.AreEqual('B', averege2);
            Assert.AreEqual('C', averege3);
            Assert.AreEqual('D', averege4);
            Assert.AreEqual('E', averege5);
        }
    }
}