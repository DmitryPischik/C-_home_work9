// Показать натуральные числа от M до N, N и M заданы

void Main()
{
    Console.WriteLine("Введите M:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите N:");
    int n = int.Parse(Console.ReadLine());
    PrintNaturalNumbers(m, n);
}
static void PrintNaturalNumbers(int m, int n) 
{
    if (m <= n) 
    {
        Console.Write($"{m} ");
        PrintNaturalNumbers(m + 1, n); 
    }
}
Main();
