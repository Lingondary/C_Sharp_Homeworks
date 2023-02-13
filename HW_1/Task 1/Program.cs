//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Проверка двух чисел A и B и нахождение большего из них.");

Console.WriteLine("Введите число A:"); 
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:"); 
int B = Convert.ToInt32(Console.ReadLine());

    if (A > B)
    {
        Console.WriteLine("A > B"); 
    }

    else
    {
        Console.WriteLine("A < B"); 
    }