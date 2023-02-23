//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Программа показывает вторую цифру числа.");

Console.WriteLine("Введите число.");
int a = Convert.ToInt32(Console.ReadLine());

int FindSecondChar(int num)
{
    int result = 0;

    result = (num/10) % 10;

    return result;
}   

Console.WriteLine(FindSecondChar(a));