// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] fillArr(int amount, int min, int max)
{
    int[] arr = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int evenCounter(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }
    System.Console.WriteLine();
}

int[] arr = fillArr(5, 100, 1001);
int evens = evenCounter(arr);
printArr(arr);
System.Console.WriteLine(evens);
