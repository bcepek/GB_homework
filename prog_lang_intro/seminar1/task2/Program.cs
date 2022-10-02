Console.Write("Enter 1st number > ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number > ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 3rd number > ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine($"Maximun number is {max}");
