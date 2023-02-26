//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Программа выводит сумму чисел в числе A.");
Console.WriteLine("Введите число А. (не более четырёх знаков)");

int A = Convert.ToInt32(Console.ReadLine());
int result = 0;

int [] digits = new int [4];

void corruption(int num)            //Использование некорректного названия обусловлено тем что это забавно
{
    int buff = 0;
    if (num.ToString().Length == 1)
    {
        buff = num % 10;
        digits [3] = buff;
    }
    else if (num.ToString().Length == 2)
    {
        buff = num % 10;
        digits [3] = buff;
        buff = (num/10) % 10;
        digits [2] = buff;
    }
    else if (num.ToString().Length == 3)
    {
        buff = num % 10;
        digits [3] = buff;
        buff = (num/10) % 10;
        digits [2] = buff;
        buff = (num/100) % 10;
        digits [1] = buff;
    }
    else if (num.ToString().Length == 4)
    {
        buff = num % 10;
        digits [3] = buff;
        buff = (num/10) % 10;
        digits [2] = buff;
        buff = (num/100) % 10;
        digits [1] = buff;
        buff = (num/1000) % 10; 
        digits [0] = buff;
    }
    else
    {
        Console.WriteLine("Неправильный ввод.");
    }
};

corruption(A);

for (int i = 0; i < digits.Length; i++)
{
    result = digits[i] + result;
}

Console.WriteLine(result);
