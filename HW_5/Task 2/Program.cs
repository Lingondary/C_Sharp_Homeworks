//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
int OddSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i] % 2 != 0)
        {
            sum = sum + array[i];
        }
    } 
    return sum;
}

int [] massive = new int [10];

Console.Clear();
FillArray(massive);
CoutArray(massive);
Console.WriteLine();
Console.WriteLine($"Сумма нечётных элементов массива: {OddSum(massive)}");
