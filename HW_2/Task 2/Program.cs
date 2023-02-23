//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Программа выводит третью цифру числа или сообщает o её отсутствии.");

Console.WriteLine("Введите число.");
int a = Convert.ToInt32(Console.ReadLine());

string FindThirdChar(int num)
{
    int result = 0;
    if (num > 99)
    {
        result = num % 10; 
        return result.ToString();
    }

    if (num > 999)
    {
        result = (num % 100) / 10; 
        return result.ToString();
    }

    if (num > 9999)
    {
        return "Число слишком большое.";
    }

    else
    {
        return "Это число не имеет третей цифры.";
    }
}   

Console.WriteLine(FindThirdChar(a));