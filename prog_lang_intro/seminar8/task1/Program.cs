/* Задайте двумерный массив. Напишите программу, которая упорядочивает
по убыванию элементы каждой строки двумерного массива*/

int rows = 5;
int columns = 6;
double[,] matrix = fillMatrix(rows, columns);
System.Console.WriteLine("Initial matrix:");
printMatrix(matrix);
System.Console.WriteLine("\nSorted matrix:");
printMatrix(sortLines(matrix));

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

void printMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

double[,] sortLines(double[,] matrix)
{
    for (int lineNumber = 0; lineNumber < matrix.GetLength(0); lineNumber++)
    {
        bool isSorted = false;
        int iterations = 0;
        while (!isSorted)
        {
            isSorted = true;
            for (int i = 0; i < matrix.GetLength(1) - 1 - iterations; i++)
            {
                if (matrix[lineNumber, i] < matrix[lineNumber, i + 1])
                {
                    double tmp = matrix[lineNumber, i];
                    matrix[lineNumber, i] = matrix[lineNumber, i + 1];
                    matrix[lineNumber, i + 1] = tmp;
                    isSorted = false;
                }
            }
            iterations++;
        }
    }
    return matrix;
}