//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
void CoutArray(double[] array)
{
    Console.WriteLine("Заполненный массив:");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}
double MaxNum(double[] array)
{
    double maxNum = array[1];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}
double MinNum(double[] array)
{
    double minNum = array[1];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;
}
double Diff(double[] array)
{
    double diff = MaxNum(array) - MinNum(array);
    return diff;
}

double [] massive = new double [10];
Console.Clear();
FillArray(massive);
CoutArray(massive);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Diff(massive)}");
