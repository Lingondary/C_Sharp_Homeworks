//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int [3, 5];

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
    Console.WriteLine();
}

int RowWithLowestSum(int[,] array)
{
    int minRow = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp > minRow)
        {
            minRow = temp;
    
            index = i + 1;
        }
    }
    return index;
}

void main()
{
    Console.WriteLine("Программа создаёт прямоугольный двумерный массив и выводит номер строки с наименьшей суммой элементов.");
    Console.Write("Исходный массив:");
    FillArray(array);
    ConsoleOutArray(array);

    Console.WriteLine($"Номер наименьшей строки: {RowWithLowestSum(array)}");
}

main();