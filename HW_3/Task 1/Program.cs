//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Проверка пятизначного числа на палиндром.");
Console.WriteLine("Введите пятизначное число.");

int inputInt = 0;
inputInt = Convert.ToInt32(Console.ReadLine());     
string inputString = Convert.ToString(inputInt);

bool CheckInput(int inputInt)
{
    if (inputInt <= 9999 || inputInt > 99999)
    {
        return false;
    }
    else
    {
       return true;
    }
}
bool IsPalindrome(string inputString)
{
     for (int i = 0; i < inputString.Length / 2; i++)
        if (inputString[i] != inputString[inputString.Length - i - 1])
            return false;
    return true;
};

if(CheckInput(inputInt) ==  false)
{
    Console.Write("Ошибка ввода, число не пятизначное. ");
}
else if(IsPalindrome(inputString) == true)
{
    Console.WriteLine("Это палиндром.");
}
else
{
    Console.WriteLine("Это не палиндром.");
}




