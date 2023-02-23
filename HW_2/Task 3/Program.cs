//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Программа принимает на вход цифру указывающую на день недели, и говорит выходной это или нет");

Console.WriteLine("Введите номер дня недели.");
int a = Convert.ToInt32(Console.ReadLine());

string IsDayOff(int num)
{
    if (num == 1)
    {
        return "Не выходной.";
    }
    if (num == 2)
    {
        return "Не выходной.";
    }
    if (num == 3)
    {
        return "Не выходной.";
    }
    if (num == 4)
    {
        return "Не выходной.";
    }
    if (num == 5)
    {
        return "Не выходной.";
    }
    if (num == 6)
    {
        return "Выходной.";
    }
    if (num == 7)
    {
        return "Выходной.";
    }
    else
    {
        return "Нет такого для недели.";
    }
}   

Console.WriteLine(IsDayOff(a));