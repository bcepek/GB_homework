// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.

int[] rndArr8()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void printArr(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[] array = rndArr8();
printArr(array);
