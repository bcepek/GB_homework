/*
Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int M = 4;
int N = 8;
System.Console.Write($"M = {M}, N = {N} -> ");
findEvens(M, N);
System.Console.WriteLine();

void findEvens(int M, int N)
{
    if (M <= N)
    {
        if (M % 2 == 0) System.Console.Write($"{M, -2}");
        findEvens(M + 1, N);
    }
}