﻿/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()?? "";
    int result = Convert.ToInt32(value);
    return result;
}
int N = Prompt("Введите число ");

void NumRes (int N)
{
int i = 1;
while (i <= N)
{
    if (i == N)
        Console.Write ($"{Math.Pow((i),3)} ");
    else
        Console.Write ($"{Math.Pow((i),3)}, ");
    i++;
}
}
NumRes (N);