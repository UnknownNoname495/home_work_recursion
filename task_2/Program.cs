// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int start, int end)
{
    if (start == end) return start;
    return start + PrintNumbers(start + 1, end);
}
if (m > n) 
{
    Console.Write("Ошибка! Число M больше числа N.");
    return;
}
Console.WriteLine($"Сумма элементов от {m} до {n} -> {PrintNumbers(m, n)}");