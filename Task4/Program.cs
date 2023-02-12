// Найти сумму элементов от M до N, N и M заданы

void Main()
{
    int M, N;
    Console.WriteLine("Введите число M");
    M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сумма от M до N: {0}", Sum(M,N));
    Console.ReadKey();
}
static int Sum(int m, int n)
{
    if (m == n) return m;
    else return m + Sum(m + 1, n);
}
Main();
