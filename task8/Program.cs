// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);
int max = N;

while (N >= 1)
{
    Console.Write($"{N} ,");
    N--;
}