
using ChallangeApp;

Employee employee1 = new Employee("Jan", "Kowalski", 39);
Employee employee2 = new Employee("Mikołaj", "Kopernik");
Employee employee3 = new Employee("Robert", "Lewandowski", 35);

employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(7);
employee1.AddScore(3);
employee1.AddScore(9);
//var ratingEmployee1 = employee1.Rating;

employee2.AddScore(8);
employee2.AddScore(2);
employee2.AddScore(6);
employee2.AddScore(6);
employee2.AddScore(9);
//var ratingEmployee2 = employee2.Rating;

employee3.AddScore(2);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(9);
//var ratingEmployee3 = employee3.Rating;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

foreach (Employee employee in employees)
{
    Console.WriteLine("Pracownik: " + employee.Name + " " + employee.Surname + " lat " + employee.Age + " zdobył " + employee.Rating);
}

int maxRating = -1;
Employee employeeWithMaxRating = new Employee();

foreach
    (Employee employee in employees)
{
    if (employee.Rating > maxRating)
    {
        employeeWithMaxRating = employee;
        maxRating = employee.Rating;
    }
}

Console.WriteLine("Pracownik z najwyższą oceną to: " + employeeWithMaxRating.Name + ". Zdobył " + maxRating + " punktów! Gratulujemy!");

