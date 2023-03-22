using ChallangeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrades(2.2f);
employee.AddGrades("Jan");
employee.AddGrades("4");
employee.AddGrades(1002);
employee.AddGrades(7);

var statistics = employee.GetStatisticsWithForeach();
Console.WriteLine($"statistics 'FOREACH': Avarenge: {statistics.Average:N2}--> Min: {statistics.Min}--> Max: {statistics.Max}");
var statistics1 = employee.GetStatisticWithFor();
Console.WriteLine($"statistics 'FOR': Avarenge: {statistics1.Average:N2}--> Min: {statistics1.Min}--> Max: {statistics1.Max}");
var statistics2 = employee.GetStatisticWithDoWhile();
Console.WriteLine($"statistics 'DoWhile': Avarenge: {statistics2.Average:N2}--> Min: {statistics2.Min}--> Max: {statistics2.Max}");
var statistics3 = employee.GetStatisticWithWhile();
Console.WriteLine($"statistics 'While': Avarenge: {statistics3.Average:N2}--> Min: {statistics3.Min}--> Max: {statistics3.Max}");

//Console.WriteLine($"Avarnge: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");


