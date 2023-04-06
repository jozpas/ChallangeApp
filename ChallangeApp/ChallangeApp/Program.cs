using ChallangeApp;



Console.WriteLine("Witamy w programi XYZ do oceny Pracowników");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine();


var employee = new EmployeeInMemory("Jan", "Kowalski");
employee.GradeAdded += EmoployeeGradeAdded;

void EmoployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę.");
}


var i = 0;
while (true)
{
    if (i == 0)
    {
        Console.WriteLine("Podaj ocene pracownika: ");
        var input1 = Console.ReadLine();
        try
        {
            employee.AddGrades(input1);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catch: {e.Message}");
        }
        i++;
    }
    Console.WriteLine("Podaj kolejną ocene pracownika lub wpiszę 'Q', żeby zakończyć dodawanie.");
    var input = Console.ReadLine();
    if (input == "Q" || input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrades(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Avarnge: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");


