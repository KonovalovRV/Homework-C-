// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Math.Sqrt - квадратный корень

int Prompt(string massage)
{
    Console.WriteLine(massage);
    string number = Console.ReadLine();
    int value = Convert.ToInt32(number);
    return value;
}

const int x = 0;
const int y = 1;
const int z = 2;

int[] point1 = InputPoint(1);
int[] point2 = InputPoint(2);

int[] InputPoint(int point)
{
    int[] result = new int[3];
    result[x] = Prompt($"Введите х {point}   ");
    result[y] = Prompt($"Введите y {point}   ");
    result[z] = Prompt($"Введите z {point}   ");
    return result;
}

int Power2(int arg)
{
    return arg * arg;
}

double length = Math.Sqrt(Power2(point1[x] - point2[x]) + Power2(point1[y] - point2[y]) + Power2(point1[z] - point2[z]));
Console.WriteLine($"{length:f2}");
