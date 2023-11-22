/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int DiapasonSum(int start, int end)
{
    int count = 0;
    for (int i = start; i <= end; i++)
    {
        count+=i;
    }
    return count;
}
System.Console.WriteLine("Введите начало диапазона");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите конец диапазона");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма натуральных чисел в диапазоне равна {DiapasonSum(a, b)}");