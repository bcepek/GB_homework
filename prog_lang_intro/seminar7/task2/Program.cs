/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
*/

int prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] fillArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
    return array;
}

double valueInArray(double[,] array, int m, int n)
{
    if (m >= 0 && n >= 0 &&
        m <= array.GetLength(0) && n < array.GetLength(1))
    {
        return array[m, n];
    }
    else
    {
        return -1;
    }
}

void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

double[,] array = fillArray(8, 4);
printArray(array);
int m = prompt("m = ");
int n = prompt("n = ");
double value = valueInArray(array, m, n);
if (value != -1)
{
    System.Console.WriteLine($"array[{m}, {n}] = {value}");
}
else
{
    System.Console.WriteLine("Incorrect address");
}
