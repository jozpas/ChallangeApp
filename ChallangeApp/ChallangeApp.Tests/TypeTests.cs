

namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CheckTwoStringAreNotEqual()
        {
            // arrange
            string text1 = "tekstPierwszy";
            string text2 = "tekstDrugi";
            
            // act

            // assert
            Assert.AreNotEqual(text1, text2);

        }
        [Test]
        public void CheckTwoIntAreEqual()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act

            // assert
            Assert.AreEqual(number1, number2);

        }
        [Test]
        public void CheckTwoEmployeeAreNotEqual()
        {
            // arrange
            var employee1= new Employee("Krystian");
            var employee2= new Employee("Janusz");
           
            // act
            
            // assert
            Assert.AreNotEqual(employee1.Name, employee2.Name);

        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
