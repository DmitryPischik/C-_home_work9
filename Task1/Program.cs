// Показать натуральные числа от 1 до N, N задано

void Main()
{
    Console.WriteLine("Введите число N:");
    int n = Convert.ToInt32(Console.ReadLine());
    NaturalNumbers(n);
}
void NaturalNumbers(int n)
{
    if (n >= 1)
    {
        NaturalNumbers(n - 1);
        Console.WriteLine(n);
    }
}
Main();
