//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Программа выдаёт двумерный массив размером M на N.");
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [m,n];

static double RandomDoubleBetween(double minValue, double maxValue)
{
    Random random = new Random();
    var next = random.NextDouble();
    return minValue + (next * (maxValue - minValue));
}
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = Math.Round(RandomDoubleBetween(0, 99), 2); 
        }
    }
}
void OutputArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

fillArray(array);
outputArray(array);