//Напишите программу, которая выводит третью цифру
//заданного числа илисообщает, что третьей цифры нет.
//Не использовать строки для расчета.
Console.Write("Enter number > ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 100)
{
    Console.WriteLine("The number doesn't have 3rd digit");
}
else
{
    while (Num > 999)
    {
        Num = Num / 10;
    }
    Console.WriteLine($"3rd digit is {Num % 10}");
}
