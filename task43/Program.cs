﻿//Задача 43: Напишите программу,
//которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число K1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число K2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void Answer(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.Write($"Точка пересечени ядвух прямых : ({x};{y})");
}

Answer(b1,k1,b2,k2);
