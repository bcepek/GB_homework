Console.Write("Enter 1st number > ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number > ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"Max = {num1}, Min = {num2}");
}
if (num2 > num1)
{
    Console.Write($"Max = {num2}, Min = {num1}");
}
if (num1 == num2)
{
    Console.Write($"Numbers are equal");
}
