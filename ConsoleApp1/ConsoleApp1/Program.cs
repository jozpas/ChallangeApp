using System.ComponentModel.Design;

var name = "Ewa";
var woman = true;
var age = 30;

if (woman == true)
{
    if (age < 30){
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine(name + ", lat " + age);
    }
} 
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Mężczyzna, lat "+age);
    }
}
Console.WriteLine("Cześć, mam na imię " + name + " i mam " + age + " lat.");