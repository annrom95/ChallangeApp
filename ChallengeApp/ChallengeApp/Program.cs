var name = "Ewa";
var sex1 = "kobieta";
var sex2 = "mężczyzna";
var age = 33;
if ((sex1 == "kobieta") && (age > 30))
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
if ((name == "Ewa") && (age == 33))
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("Malwina, lat 40");
}
if ((sex2 == "mężczyzna") && (age > 18))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Pełnoletni mężczyzna");
}