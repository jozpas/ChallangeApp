namespace ChallangeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeSetsPoints_ShouldReturnRating()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(4);
            employee.AddScore(-15);

            // act
            var rating = employee.Rating;

            // assert
            Assert.AreEqual(0, rating);

        }
    }
}