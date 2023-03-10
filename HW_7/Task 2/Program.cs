//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Задан массив 12 на 12 символов. Программа принимает на вход позицию элемента в массиве и выдаёт его значение в консоль.");
Console.WriteLine("Позиция элемента имеет формат [X,Y].");

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [12,12];

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
           array[i, j] = new Random().Next(0, 999); 
        }
    }
}
void NumOutput(int[,] array, int x, int y)
{
    if ( x > 12 | y > 12)
    {
        Console.WriteLine("Элемента с такими индексами нет.");
    }
    else
    {
        int output = array[x,y];
        Console.WriteLine($"{output}");
    }
}

FillArray(array);
NumOutput(array, x, y);

