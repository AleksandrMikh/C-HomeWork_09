﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




Console.WriteLine("Введите числа");

Console.WriteLine("Введите B1:");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите K1:");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B2:");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите K2:");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"две прямые пересекутся в точке X: {x}, Y: {y}");
