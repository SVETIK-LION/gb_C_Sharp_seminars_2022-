/* Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве. */


string DistanceBtwnPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int A = x2 - x1;
    int B = y2 - y1;
    int C = z1 - z2;

    double length = Math.Round(Math.Sqrt(A * A + B * B + C * C), 2);

    return ($"Расстояние между точками: {length}");
}


Console.WriteLine(DistanceBtwnPoints(3, 6, 8, 2, 1, -7));
