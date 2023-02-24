//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Программа принимает на вход координаты двух точек в 3D пространстве, и находит расстояние между ними.");
Console.WriteLine("Необходимо ввести координаты двух точек.");
double getDistance(double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}

Console.WriteLine("Введите поочерёдно три координаты точки A (x, y, z). Нажмите Enter после ввода каждого числа.");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите поочерёдно три координаты точки B (x, y, z). Нажмите Enter после ввода каждого числа.");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: ");
Console.WriteLine(getDistance(xa, xb, ya, yb, za, zb));