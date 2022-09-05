// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите M");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(numberN, numberM);

void PrintNumbersToN(int n, int m)
{
    if (n < 1) return;
    PrintNumbersToN(n - 1, m);
    Console.Write(n + " ");
}