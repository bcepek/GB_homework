/*
Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int M = 1;
int N = 15;
System.Console.WriteLine($"M = {M}, N = {N} -> {sumBetweenInts(M, N)}");

int sumBetweenInts(int M, int N)
{
    if (M < N) return M + sumBetweenInts(M + 1, N);
    else return M;
}