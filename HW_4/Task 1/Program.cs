//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Программа возводит число A в степень B.");

Console.WriteLine("Введите число A.");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B.");
int B = Convert.ToInt32(Console.ReadLine());

double result = A;

for (int i = 1; i < B; i++)
{   
    result = result * A;
};

Console.WriteLine(result);