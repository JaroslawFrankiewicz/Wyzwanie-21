using System;
using Wyzwanie_21;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade(2L);
employee.AddGrade(5);
employee.AddGrade(3);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Sum: {statistics.Sum}");

//SetSth(out statistics);
//void SetSth(out Statistics statistics)
//{
//    statistics = new Statistics();
//}