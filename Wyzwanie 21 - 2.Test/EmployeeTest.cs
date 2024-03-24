

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
            employee.AddGrade('A');
            employee.AddGrade('a');
            employee.AddGrade(30);
            employee.AddGrade(20);

            // act

            var result = employee.GetStatistics();

            // assert

            Assert.AreEqual(100, result.Max);

        }

        [Test]
        public void WhenEmployeeCollectGrades_Getstatistics_ShouldReturnCorrectMinGrade()
        {
            // arrange

            var employee = new Employee("Adam", "Kamizelich");
            var statistics = new Statistics();
            employee.AddGrade('B');
            employee.AddGrade('b');
            employee.AddGrade(60);
            employee.AddGrade(30);

            // act

            var result = employee.GetStatistics();

            // assert

            Assert.AreEqual(30, result.Min);

        }

        [Test]
        public void WhenEmployeeCollectGrades_Getstatistics_ShouldReturnCorrectAverageGrade()
        {
            // arrange

            var employee = new Employee("Adam", "Kamizelich");
            var statistics = new Statistics();
            employee.AddGrade('c');
            employee.AddGrade('C');
            employee.AddGrade(80);
            employee.AddGrade(60);

            // act

            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(65.00, 2), Math.Round(result.Average, 2));

        }

        [Test]
        public void WhenEmployeeCollectGrades_Getstatistics_ShouldReturnCorrectAverageLetter()
        {
            // arrange

            var employee = new Employee("Adam", "Kamizelich");
            var statistics = new Statistics();
            employee.AddGrade('d');
            employee.AddGrade('D');
            employee.AddGrade(40);
            employee.AddGrade(50);

            // act

            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('C', result.AverageLetter);

        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
