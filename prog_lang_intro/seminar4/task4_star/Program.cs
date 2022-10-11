// Напишите программу, которая из массива случайных чисел. Ищет второй максимум 
// (число меньше максимального элемента, но больше всех остальных).
// Постарайтесь сделать одним циклом

int max2(int[] arr)
{
    int max = arr[0];
    int result = max;
    // единственный цикл
    for (int i = 0; i < arr.Length; i++)
    {
        // если вдруг максимальное число оказалось в начале массива:
        if (result == max && result > arr[i])
        {
            result = arr[i];
        }
        // обновляем максимумы:
        if (max < arr[i])
        {
            result = max;
            max = arr[i];
        }
        // если вдруг нашли новый второй максимум, который раньше не встречался:
        if (arr[i] > result && arr[i] < max)
        {
            result = arr[i];
        }
    }
    if (result == max)
    {
        System.Console.WriteLine("Second maximum does not exist");
    }
    return result;
}

// генерация случайного массива с заданными параметрами
int[] rndArr(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[] arr = rndArr(6, 0, 10);   // длина, мин, макс
printArr(arr);
int result = max2(arr);
System.Console.WriteLine(result);
