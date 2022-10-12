// Задача 3
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Prompt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int N = Prompt("Введите число   ");
if (N < 1)
    Console.WriteLine("Число меньше единицы, введите положительное число");
int count = 1;
int cubnamber = 0;
while (count <= N)
{
    cubnamber = count * count * count;
    System.Console.WriteLine($"{cubnamber}");
    count = count + 1;
}
