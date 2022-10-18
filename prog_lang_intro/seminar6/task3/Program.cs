// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] mat = fillMat(3, 6);
int[] maxs = max(mat, 1);
int[] mins = min(mat, 0);
int result = sumLine(maxs) - sumLine(mins);
taskOutput(mat, maxs, mins, result);


void taskOutput(int[,] mat, int[] maxs, int[] mins, int result)
{
    printMat(mat);
    System.Console.WriteLine("Maximums in rows:");
    printLine(maxs);
    System.Console.WriteLine("Minimums in columns:");
    printLine(mins);
    System.Console.WriteLine("Difference between theis sums:");
    System.Console.WriteLine($"{sumLine(maxs)} - {sumLine(mins)} = {result}");
}

int[,] fillMat(int rows, int cols, int minVal = 0, int maxVal = 10)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return matrix;
}

void printMat(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            System.Console.Write($"{mat[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void printLine(int[] line)
{
    for (int i = 0; i < line.Length; i++)
    {
        System.Console.Write($"{line[i]}\t");
    }
    System.Console.WriteLine();
}

int sumLine(int[] line)
{
    int result = 0;
    for (int i = 0; i < line.Length; i++)
    {
        result += line[i];
    }
    return result;
}

int[] max(int[,] array, int dim = 0)
{
    int resultLen = 0;
    if (dim == 0)
    {
        resultLen = array.GetLength(1);
    }
    else
    {
        resultLen = array.GetLength(0);
    }
    int[] result = new int[resultLen];
    switch (dim)
    {
        case 0:
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[0, i];
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (result[i] < array[j, i])
                    {
                        result[i] = array[j, i];
                    }
                }
            }
            break;
        case 1:
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[i, 0];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (result[i] < array[i, j])
                    {
                        result[i] = array[i, j];
                    }
                }
            }
            break;
    }
    return result;
}

int[] min(int[,] array, int dim = 0)
{
    int resultLen = 0;
    if (dim == 0)
    {
        resultLen = array.GetLength(1);
    }
    else
    {
        resultLen = array.GetLength(0);
    }
    int[] result = new int[resultLen];
    switch (dim)
    {
        case 0:
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[0, i];
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (result[i] > array[j, i])
                    {
                        result[i] = array[j, i];
                    }
                }
            }
            break;
        case 1:
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[i, 0];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (result[i] > array[i, j])
                    {
                        result[i] = array[i, j];
                    }
                }
            }
            break;
    }
    return result;
}
