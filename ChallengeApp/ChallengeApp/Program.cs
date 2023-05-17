string name = "Ewa";
string sex1 = "kobieta";
string sex2 = "mężczyzna";
int age1 = 25;
int age2 = 17;
if (sex1 == "kobieta" && age1 == 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age1 < 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else
{
    Console.WriteLine("Ewa, lat 40.");
}
if (age2 == 18 && sex2 == "mężczyzna") 
{
    Console.WriteLine("Pełnoletni mężczyzna.");
}
else if (age2 > 15)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}