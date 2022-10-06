//Напишите программу, которая принимает на вход
//цифру,обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.Write("Enter day number > ");
int daynum = Convert.ToInt32(Console.ReadLine());
if (daynum > 0 && daynum < 8)
{
    if (daynum > 5)
    {
        Console.WriteLine("Weekend");
    }
    else
    {
        Console.WriteLine("Work day");
    }
}
else
{
    Console.WriteLine("Incorrect day number");
}
