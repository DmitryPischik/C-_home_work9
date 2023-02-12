// Написать программу возведения числа А в целую стень B


double Power(double a, int b)
{
    if (b < 0) return 1 / Power(a, -b);
    if (b == 0) return 1;
    if (b % 2 == 0) return Power(a * a, b / 2); // Чётная степень.
    else return a * Power(a * a, b / 2); // Нечётная степень.
}

void Main()
{
    Console.WriteLine("Введите основание степени a:"); 
    double a = double.Parse(Console.ReadLine()); 
    Console.WriteLine("Введите показатель степени b:");  
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("{0}^{1} = {2}", a, b, Power(a, b));
}
Main();
