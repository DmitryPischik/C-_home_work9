// Написать программу вычисления функции Аккермана

static int AkkermansFunction(int m, int n) 
{ 
    if (m == 0) 
    { 
        return n + 1; 
    } 
    else if (n == 0) 
    { 
        return AkkermansFunction(m - 1, 1); 
    } 
    else 
    { 
        return AkkermansFunction(m - 1, AkkermansFunction(m, n - 1)); 
    } 
}

Console.WriteLine("Введите m:"); 
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите n:");  
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Результат: " + AkkermansFunction(m, n));  
Console.ReadKey();
