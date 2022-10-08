// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

int prompt(string msg)
{
    System.Console.Write(msg);
    int ans = Convert.ToInt32(Console.ReadLine());
    return ans;
}

int digit_counter(int num)
{
    int digit_amount = 1;
    while (num > 9)
    {
        num = num / 10;
        digit_amount++;
    }
    return digit_amount;
}

// вводим число и считаем к-во его цифр
int num = prompt("Enter number > ");
int digit_amount = digit_counter(num);
// записываем его цифры в элементы массива
int[] digits = new int[digit_amount];
for (int i = 0; i < digit_amount; i++)
{
    digits[i] = num % 10;
    num /= 10;
}

// проверка массива на симметричность
bool ispoly = true;
for (int i = 0; i < digit_amount / 2; i++)
{
    if (digits[i] != digits[digit_amount - i - 1])
    {
        ispoly = false;
        break;  // выходим из цикла после первого несоответствия
    }
}

// вывод результата
if (ispoly) System.Console.WriteLine("Number is polyndrom");
else System.Console.WriteLine("Number is NOT polyndrom");
