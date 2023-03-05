/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();

int GetSum(int sum)
{
    int result = 0;
    for (int i = sum; i > 1; i %= 10)
    {
        result = +i;
    }
    return result;

}

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {a} равно {GetSum(a)}");
