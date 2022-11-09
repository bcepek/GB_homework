/*Задайте две матрицы. Напишите программу, которая
будет находить произведение двух матриц.*/

int rowsA = 3;
int columnsA = 2;
int rowsB = columnsA;
int columnsB = 4;
int[,] A = fillMatrix(rowsA, columnsA);
int[,] B = fillMatrix(rowsB, columnsB);
int[,] C = crossProduct(A, B);
System.Console.WriteLine("First array:");
printArray(A);
System.Console.WriteLine("\nSecond array:");
printArray(B);
System.Console.WriteLine("\nCross product:");
printArray(C);

int[,] fillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(-9, 10);
        }
    }
    return matrix;
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

int[,] crossProduct(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < A.GetLength(1); k++)
            {
                result[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return result;
}