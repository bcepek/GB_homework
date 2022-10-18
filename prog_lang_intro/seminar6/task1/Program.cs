// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает
// количество положительных)

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] dataInput(int M)
{
    int[] data = new int[M];
    for (int i = 0; i < M; i++)
    {
        System.Console.Write($"enter number {i + 1} of {M} > ");
        data[i] = Convert.ToInt32(Console.ReadLine());
    }
    return data;
}

int posNumAmount(int[] data)
{
    int result = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] > 0) result++;
    }
    return result;
}

int M = 8;
int[] array = dataInput(M);
int posAmount = posNumAmount(array);
System.Console.WriteLine($"There are {posAmount} positive elements in array");
