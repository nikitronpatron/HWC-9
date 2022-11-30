// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = int.Parse(Console.ReadLine());
PrintNumbersFrom(n, 1);

void PrintNumbersFrom(int start, int end)
{
    Console.Write($"{start} ");
    if(start == 1) return;
    PrintNumbersFrom(start - 1, end);
}