// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int b = 0;
const int k = 1;
const int X = 0;
const int Y = 1;

int[] getLinePar(int num)
{
    int[] coef = new int[2];
    System.Console.Write($"b{num} = ");
    coef[b] = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"k{num} = ");
    coef[k] = Convert.ToInt32(Console.ReadLine());
    return coef;
}

float[] findIntersection(int[] line1, int[] line2)
{
    float[] coords = new float[2];
    coords[X] = (float)(line2[b] - line1[b]) / (line1[k] - line2[k]);
    coords[Y] = line1[k] * coords[X] + line1[b];
    return coords;
}

void printCoords(float[] coords)
{
    System.Console.WriteLine($"({coords[X]}; {coords[Y]})");
}

int[] line1 = getLinePar(1);
int[] line2 = getLinePar(2);
float[] coords = findIntersection(line1, line2);
printCoords(coords);
