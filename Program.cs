// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int cube = 1;
while (cube <= N)
{
    Console.Write($"{Math.Pow(cube, 3)}");
    if (cube != N)
    {
        Console.Write(", ");
    }
    cube++;
}