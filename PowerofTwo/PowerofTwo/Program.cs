// See https://aka.ms/new-console-template for more information
Console.WriteLine("Power Of Two");


int power, result = 1;
Console.WriteLine("Enter the power of 2 : ");
power = Convert.ToInt32(Console.ReadLine());
if (power < 31 && power >= 0)
{
    while (power != 0)
    {
        result = result * 2; --power;
    }
    Console.WriteLine("Answer = " + result);
}
else
{
    Console.WriteLine("Wrong input will over flow int");
}