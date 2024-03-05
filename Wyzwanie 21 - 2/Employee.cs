
namespace Wyzwanie_21
{
    public class Employee
    {

        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name
        {
            get;
            private set;
        }
        public string Surname
        {
            get;
            private set;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void Addgrade(double grade)
        {
            double gradeInDouble = (float)grade;
            this.Addgrade(gradeInDouble);
        }

        public void Addgrade(int grade)
        {
            var gradeInInt = (float)grade;
            this.Addgrade(gradeInInt);
        }

        public void AddGrade(long grade)
        {
            var gradeInLong = (float)grade;

            if (gradeInLong >= 0 && gradeInLong <= 100)

            {
                this.AddGrade(gradeInLong);
            }
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                statistics.Sum += this.grades[index];
                index++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;
            var index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                statistics.Sum += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                statistics.Sum += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;

            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                statistics.Sum += this.grades[index];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
