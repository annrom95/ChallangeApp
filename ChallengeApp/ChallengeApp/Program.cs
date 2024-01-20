int number = 1188;
string numberInString = number.ToString();
char[] numbers = numberInString.ToArray();
var numbers0 = 0;
var numbers1 = 0;
var numbers2 = 0;
var numbers3 = 0;
var numbers4 = 0;
var numbers5 = 0;
var numbers6 = 0;
var numbers7 = 0;
var numbers8 = 0;
var numbers9 = 0;

foreach (char letter in numbers)
{
   if (letter == '0')
    {
        numbers0++;
    }
   else if (letter == '1')
    {
        numbers1++;
    }
   else if (letter == '2')
    {
        numbers2++;
    }
   else if (letter == '3')
    {
        numbers3++;
    }
   else if (letter == '4')
    {
        numbers4++;
    }
   else if (letter == '5')
    {
        numbers5++;
    }
   else if (letter == '6')
    {
        numbers6++;
    }
   else if (letter == '7')
    {
        numbers7++;
    }
   else if (letter == '8')
    {
        numbers8++;
    }
   else if (letter == '9')
    {
        numbers9++;
    }
}
Console.WriteLine("0=>" + numbers0);
Console.WriteLine("1=>" + numbers1);
Console.WriteLine("2=>" + numbers2);
Console.WriteLine("3=>" + numbers3);
Console.WriteLine("4=>" + numbers4);
Console.WriteLine("5=>" + numbers5);
Console.WriteLine("6=>" + numbers6);
Console.WriteLine("7=>" + numbers7);
Console.WriteLine("8=>" + numbers8);
Console.WriteLine("9=>" + numbers9);




    