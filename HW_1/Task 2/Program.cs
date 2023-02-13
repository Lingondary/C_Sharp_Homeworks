// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int max;
Console.Clear();
Console.WriteLine("Программа сравнивает 3 числа (А, B и C) и выдаёт максимальное.");

Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C:");
int C = Convert.ToInt32(Console.ReadLine());

if(A < B)
{
    max = B;
}

else
{
    max = A;
}

if(max < C)
{
    max = C;
}

Console.WriteLine("Наибольшее число: " + max);
