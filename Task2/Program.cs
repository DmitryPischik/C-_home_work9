// Показать натуральные числа от N до 1, N задано

void Main()
{
    Console.WriteLine("Введите N:");
    int n = int.Parse(Console.ReadLine());
    PrintNaturalNumbers(n);
}
void PrintNaturalNumbers(int n) 
{
    if (n != 0) 
    {
        Console.WriteLine(n);
        PrintNaturalNumbers(n - 1);
    }
    
}

Main();
