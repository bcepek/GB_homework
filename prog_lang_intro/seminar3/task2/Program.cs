// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

const int X = 0, Y = 1, Z = 2;

int[] ReadPoint(int PointNum)
{
    int[] result = new int[3];
    System.Console.Write($"X{PointNum} = ");
    result[X] = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Y{PointNum} = ");
    result[Y] = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Z{PointNum} = ");
    result[Z] = Convert.ToInt32(Console.ReadLine());

    return result;
}

int[] p1 = ReadPoint(1);
int[] p2 = ReadPoint(2);

double length = Math.Sqrt(Math.Pow(p1[X] - p2[X], 2) + Math.Pow(p1[Y] - p2[Y], 2) + Math.Pow(p1[Z] - p2[Z], 2));

System.Console.WriteLine($"distance is {length:f2}");
