// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр

int digitCounter(int num)
{
    int digitNum = 0;
    if (num == 0) digitNum = 1;
    while (num > 0)
    {
        num /= 10;
        digitNum++;
    }
    return digitNum;
}

int digitSum(int num)
{
    int digitNum = digitCounter(num);
    int result = 0;
    for (int i = 0; i < digitNum; i++)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

int prompt(string msg)
{
    System.Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int a = prompt("Enter number > ");
int result = digitSum(a);
System.Console.WriteLine(result);
