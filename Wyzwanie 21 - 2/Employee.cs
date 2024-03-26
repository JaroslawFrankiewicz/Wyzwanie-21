namespace Wyzwanie_21
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee()
        {
        }
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
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if
                (char.TryParse(grade, out char res))
            {
                this.AddGrade(res);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(double grade)
        {
            var gradeInDouble = (float)grade;
            this.AddGrade(gradeInDouble);
        }

        public void AddGrade(int grade)
        {
            var gradeInInt = (float)grade;
            this.AddGrade(gradeInInt);
        }

        public void AddGrade(long grade)
        {
            var gradeInLong = (float)grade;

            if (gradeInLong >= 0 && gradeInLong <= 100)

            {
                this.AddGrade(gradeInLong);
            }
        }       

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
