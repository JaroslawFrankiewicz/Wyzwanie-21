using System;
using Wyzwanie_21;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade(2L);
employee.AddGrade(5);
employee.AddGrade(3);
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("Loop \"ForEach\":");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Sum: {statistics1.Sum}");
Console.WriteLine("Loop \"For\":");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Sum: {statistics2.Sum}");
Console.WriteLine("Loop \"DoWhile\":");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Sum: {statistics3.Sum}");
Console.WriteLine("Loop \"While\":");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Sum: {statistics4.Sum}");


//SetSth(out statistics);
//void SetSth(out Statistics statistics)
//{
//    statistics = new Statistics();
//}