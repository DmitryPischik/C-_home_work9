// Найти сумму цифр числа


void Main()
{
    Console.WriteLine("Введите натуральное число: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine($"Сумма цифр числа {num} равна {SumOfDigits(num)}");
}
int SumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return (num % 10 + SumOfDigits(num / 10));
}

Main();
