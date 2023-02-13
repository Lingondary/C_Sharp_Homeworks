//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
int current = 1;

Console.Clear();
Console.WriteLine("Программа показывает все чётные числа от 1 до N.");

Console.WriteLine("Введите число N:");
N = Convert.ToInt32(Console.ReadLine());

while (current < N)
{
    if (current % 2 == 0)
    {
        Console.WriteLine(current);
    }
    current++;
}