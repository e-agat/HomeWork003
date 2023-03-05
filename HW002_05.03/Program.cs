/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();

int GetSum(int sum)
{
    int result = 0;
  
    
    for (int i = sum; i > 1; sum =sum/10)
    {
        i=i% 10;
        result = +i;
    }
    return result;

}

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {a} равно {GetSum(a)}");
