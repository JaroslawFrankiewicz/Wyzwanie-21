using System;
using Wyzwanie_21;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("Naciśnij q aby wyjść");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee();

//try
//{
//    Employee enp = null;
//    var name = employee.Surname;
//}
//catch (Exception exception)
//{
//    Console.WriteLine("Takiej sytuacji nie powinno być");
//}
//finally
//{
//    Console.WriteLine("Finally here");
//}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Exception catched: {ex.Message}");

    }
    
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
