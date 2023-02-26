//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Программа создаёт и выводит случайный массив.");

Random rnd = new Random();
int [] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 100);
    Console.Write(array[i] + " ");
};