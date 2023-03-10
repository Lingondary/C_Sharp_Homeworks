//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Программа выводит двумерный массив и подсчитывает среднее арифмитическое элементов в каждом столбце.");
int x = 5; 
int y = 5;
int [,] array = new int [x,y];

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = new Random().Next(0, 99); 
        }
    }
}
void OutputArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Averages(int[,] array)
{
    int buff = 0;
    double[] averages = new double[array.GetLength(0)];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            buff = array[i,j] + buff;
        }
        averages[j] = buff / array.GetLength(1) ;
        Console.Write($"{averages[j]} ");
        buff = 0;
    }
}

FillArray(array);
OutputArray(array);
Averages(array);
