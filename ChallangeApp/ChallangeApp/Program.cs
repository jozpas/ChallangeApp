using ChallangeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrades("1000");
employee.AddGrades("Jan");
employee.AddGrades(1.5f);
employee.AddGrades(7.5f);
employee.AddGrades(7.56668d);
employee.AddGrades(756);

var statistics = employee.GetStatistics();


Console.WriteLine($"Avarnge: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


