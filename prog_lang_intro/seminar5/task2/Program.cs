// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] fillArr(int amount, int min, int max)
{
    int[] arr = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int oddPosCounter(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    return result;
}

void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[] arr = fillArr(4, -100, 101);
int odds = oddPosCounter(arr);
printArr(arr);
System.Console.Write(odds);
