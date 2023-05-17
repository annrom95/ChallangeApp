string name = "Ewa";
string sex = "kobieta";
int age1 = 25;
int age2 = 33;
if (sex == "kobieta" && age1 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta powyżej 30 lat.");
}
if (name == "Ewa" && age2 == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (sex == "mężczyzna" && age1 > 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}