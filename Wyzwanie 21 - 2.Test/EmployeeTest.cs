

namespace Wyzwanie_21.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenEmployeeCollectGrades_Getstatistics_ShouldReturnCorrectMaxGrade()
        {
            // arrange

            var employee = new Employee("Adam", "Kamizelich");
            var statistics = new Statistics();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act

            var result = employee.GetStatistics();

            // assert

            Assert.AreEqual(3, result.Max);

        }

        [Test]
        public void WhenEmployeeCollectGrades_Getstatistics_ShouldReturnCorrectMinGrade()
        {
            // arrange

            var employee = new Employee("Adam", "Kamizelich");
            var statistics = new Statistics();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act

            var result = employee.GetStatistics();

            // assert

            Assert.AreEqual(1, result.Min);

        }

        [Test]
        public void WhenEmployeeCollectGrades_Getstatistics_ShouldReturnCorrectAverageGrade()
        {
            // arrange

            var employee = new Employee("Adam", "Kamizelich");
            var statistics = new Statistics();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act

            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, result.Average);

        }

        [Test]
        public void WhenEmployeeCollectGrades_Getstatistics_ShouldReturnCorrectSumOfGrades()
        {
            // arrange

            var employee = new Employee("Adam", "Kamizelich");
            var statistics = new Statistics();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act

            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, result.Sum);

        }
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
