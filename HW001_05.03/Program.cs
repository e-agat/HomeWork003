﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();

int RaiseNumToPower(int m, int n)
{
    int result = m;
    for (int i = 1; i < n; i++)
    {
result*=m;
    } 
    
   return result;
}
int a = 3;
int b = 5;
Console.WriteLine ($"{a} в степени {b} равно {RaiseNumToPower(a, b)}");
