﻿//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// Пример: 8 -> 2, 4, 6, 8
//         5 -> 2, 4

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;
while(temp <= N)
{
    if(temp%2 > 0)
    {
        temp++;
    }
    else
    {
        Console.Write($"{temp} ");
        temp++;
    }
}