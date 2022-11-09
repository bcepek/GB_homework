/*Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.*/

int rows = 6;
int columns = 3;
double[,] array = fillMatrix(rows, columns);
printArray(array);
System.Console.WriteLine($"\nRow number with minimum element sum is {findMinimumLine(array)}");

double[,] fillMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(0, 10) + rnd.NextDouble();
        }
    }
    return matrix;
}

int findMinimumLine(double[,] matrix)
{
    int minLineNumber = 1;
    double minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum || i == 0)
        {
            minSum = sum;
            minLineNumber = i;
        }
    }
    return minLineNumber;
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