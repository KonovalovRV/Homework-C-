// Задача 1
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string massage)
{
    Console.WriteLine(massage);
    string number = Console.ReadLine();
    int value = Convert.ToInt32(number);
    return value;
}

int number = Prompt("Введите пятизначное число   ");

bool ValidatePalindrom(int value)
{
    if (value < 10000 || value > 99999)
    {
        System.Console.WriteLine("Это не пятизначное число");
        return false;
    }
    return true;
}

bool Validate(int result)
{
    if (number / 10000 == number % 10 && (number / 10) % 10 == (number / 1000) % 10)
    {
        Console.WriteLine("Это полиндром");
        return true;
    }
    Console.WriteLine("Это не полиндром");
    return false;  
}

if (ValidatePalindrom(number))
{
   if (Validate(number)){}  
}
