// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(number);

int SumNCount(int number);

int PrintNumbersToN(int n)
{
    int temo = 0;
    if (n < 0) return 0;
    PrintNumbersToN(n / 10);
    temp = temp + n % 10;
    Console.Write(temp + " ");
}
