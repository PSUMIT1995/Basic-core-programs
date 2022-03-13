// See https://aka.ms/new-console-template for more information
Console.WriteLine("Odd Even Numbers");
int i;
Console.WriteLine("Enter a Number : ");
i = int.Parse(Console.ReadLine());
if (i % 2 == 0)
{
    Console.WriteLine("Entered Number is an Even Number");
}
else
{
    Console.WriteLine("Entered Number is an Odd Number");
}
