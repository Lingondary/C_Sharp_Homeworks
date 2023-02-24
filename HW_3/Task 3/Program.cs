//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Программа принимает на вход число N и выдаёт таблицу кубов чисел от одного до N.");
Console.WriteLine("Введите число N.");

int N = Convert.ToInt32(Console.ReadLine());
int counter = 0;

while (counter < N)
{
    Console.Write(Math.Pow(counter, 2) + " ");
    counter++;
}