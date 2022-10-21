/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] fillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void printRow(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]:f2}\t");
    }
}

double[] meanInColumn(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result[j] = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[j] += array[i, j];
        }
        result[j] /= array.GetLength(0);
    }
    return result;
}

int[,] array = fillArray(3, 8);
printArray(array);
double[] meanRow = meanInColumn(array);
System.Console.WriteLine();
System.Console.WriteLine("Mean values of each columns are:");
printRow(meanRow);
