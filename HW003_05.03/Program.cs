/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

void FillArray(int[] array, int min, int max)
{
    int arrayLength = array.Length;
    for (int i = 0; i < arrayLength; i++)
    {

        array[i] = new Random().Next(min, max);
    }

}
void PrintArray(int[] array,int min, int max)
{
    Console.WriteLine("");

}
int[] array = new int[8];
int a = 1;
int b = 45;
FillArray(array,a,b);
PrintArray(array,a,b);
Console.WriteLine($"[{string.Join(", ", array)}]");
