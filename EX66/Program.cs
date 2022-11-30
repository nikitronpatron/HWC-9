// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int printSum = PrintSumNumbers(m, n);
Console.WriteLine(printSum);

int PrintSumNumbers(int start, int end)
{
    if(start == end) return start;
    return start + PrintSumNumbers(start + 1, end);
}