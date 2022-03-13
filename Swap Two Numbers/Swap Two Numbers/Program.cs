// See https://aka.ms/new-console-template for more information
Console.WriteLine("Swap Two Numbers");

int number1, number2, temporary;

Console.Write("\nEnter the First Number : ");
number1 = Convert.ToInt32
(Console.ReadLine());

Console.Write("\nEnter the Second Number : ");
number2 = Convert.ToInt32
(Console.ReadLine());

temporary = number1;
number1 = number2;
number2 = temporary;
Console.Write("\nAfter Swapping : ");
Console.Write("\nFirst Number : " + number1);
Console.Write("\nSecond Number : " + number2);
Console.ReadLine();