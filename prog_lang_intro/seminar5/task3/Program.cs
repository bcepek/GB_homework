// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] fillArr(int amount, int min, int max)
{
    int[] arr = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
        //System.Console.WriteLine(arr[i]);
    }
    System.Console.WriteLine();
}

int max(int[] arr)
{
    int result = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > result)
        {
            result = arr[i];
        }
    }
    return result;
}

int min(int[] arr)
{
    int result = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < result)
        {
            result = arr[i];
        }
    }
    return result;
}

int[] arr = fillArr(5, 1, 100);
printArr(arr);
System.Console.WriteLine(max(arr) - min(arr));
