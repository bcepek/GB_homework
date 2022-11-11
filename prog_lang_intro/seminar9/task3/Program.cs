/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

int m = 3;
int n = 4;
int ackermannResult = ackermann(m, n);
if (ackermannResult != -1)
{
System.Console.WriteLine($"A({m}, {n}) = {ackermannResult}");
}
else
{
    System.Console.WriteLine("Incorrect input");
}

int ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return ackermann(m - 1, ackermann(m, n - 1));
    }
    else return -1;
}