//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int A;

Console.Clear();
Console.WriteLine("Программа проверяет чётность числа.");

Console.WriteLine("Введите число: ");
A = Convert.ToInt32(Console.ReadLine());

if (A % 2 == 0)
{
    Console.WriteLine("Число чётное.");
}

else
{
 Console.WriteLine("Не чётное.");   
}