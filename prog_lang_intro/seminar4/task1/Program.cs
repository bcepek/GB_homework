// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B (и в нулевую степень).
// Использовать свои функции, не использовать Math.Pow

int power(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
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
int b = prompt("Enter power > ");
int ans = power(a, b);
System.Console.WriteLine($"{a}^{b} = {ans}");
