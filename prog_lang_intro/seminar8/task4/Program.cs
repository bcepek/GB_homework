/*Напишите программу, которая заполнит
спирально квадратный массив.*/

int length = 10;
int[,] array = spiralFill(length);
printArray(array);

int[,] spiralFill(int length)
{
    int[,] array = new int[length, length];
    int row = 0;
    int column = 0;
    int count = 0;
    while (true)
    {
        for (int i = column; i < length - column; i++)    // move right
        {
            array[row, i] = count;
            count++;
            if (count >= length * length)
            {
                return array;
            }
        }
        for (int i = row + 1; i < length - row; i++)    // move down
        {
            array[i, length - 1 - column] = count;
            count++;
        }
        for (int i = length - 2 - column; i > column - 1; i--)    // move left
        {
            array[length - row - 1, i] = count;
            count++;
            if (count >= length * length)
            {
                return array;
            }
        }
        row++;
        for (int i = length - 1 - row; i > row - 1; i--)    // move up
        {
            array[i, column] = count;
            count++;
        }
        column++;
    }
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
    System.Console.WriteLine();
}