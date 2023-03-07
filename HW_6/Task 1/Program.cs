//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Программа выводит на экран количество введёных в массив чисел больше 0.");
Console.WriteLine("Введите 7 чисел, нажимая Enter после ввода кажого числа.");

void fillArray(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int aboveZeroCounter(int[] Array)
{
    int counter = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if(Array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

int[] Array = new int [7];

fillArray(Array);

Console.Write("Количество чисел больше нуля: ");
Console.Write($"{aboveZeroCounter(Array)}");