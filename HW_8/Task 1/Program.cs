//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[4,4];

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0, 9);
}

void ConsoleOutArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
    }
}

void SortRowsOfArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int buff = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = buff;
                }
            }
}

void Rotate(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1)/2); j++)
        {
            temp = array[i, j];
            array[i, j] = array[i, array.GetLength(1) - 1 - j];
            array[i, array.GetLength(1) - 1 - j] = temp;
        }
    }
}


void main()
{
Console.WriteLine("Программа генерирует двумерный массив, после чего упорядочивает каждую строку по убыванию.");

Console.Write("Исходный массив: ");
    FillArray(array);
    ConsoleOutArray(array);

Console.WriteLine();

Console.Write("Отсортированный массив: ");
    SortRowsOfArray(array);
    Rotate(array);
    ConsoleOutArray(array);
}

main();