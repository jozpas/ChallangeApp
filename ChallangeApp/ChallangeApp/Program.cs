using ChallangeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrades(2);
employee.AddGrades(1.5f);
employee.AddGrades(7.5f);

var statistics = employee.GetStatistics();


Console.WriteLine($"Avarnge: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


