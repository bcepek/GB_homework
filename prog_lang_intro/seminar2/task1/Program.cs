//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа. Не использовать 
//строки для расчета.

int num = 0;
while (num < 100 || num > 999)
{
    Console.Write("Enter 3-digit number > ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"2nd number is {(num / 10) % 10}");
