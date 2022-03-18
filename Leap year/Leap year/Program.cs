// See https://aka.ms/new-console-template for more information
Console.WriteLine("Leap Year");

Console.WriteLine("Enter Year : ");
int Year = Convert.ToInt16(Console.ReadLine());
if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
{
    Console.WriteLine("{0} is a Leap Year.", Year);
}
else
{
    Console.WriteLine("{0} is not a Leap Year.", Year);
}