// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

int prompt(string msg)
{
    System.Console.Write(msg);
    int ans = Convert.ToInt32(Console.ReadLine());
    return ans;
}

int num = prompt("Enter number > ");
for (int i = 1; i <= num; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}
