//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
void CoutArray(int[] array)
{
    Console.WriteLine("Заполненный массив:");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void IsEvenCounter(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i] % 2 == 0)
        {
            counter++;
        }
    } 
    Console.WriteLine($"Количество чётных чисел: {counter}");
}

int [] massive = new int [10];

Console.Clear();
FillArray(massive);
CoutArray(massive);
IsEvenCounter(massive);