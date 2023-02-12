// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем


void Main()
{
    Console.WriteLine("Введите два первых числа последовательности: ");
    int firstNumber = int.Parse(Console.ReadLine());
    int secondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество элементов последовательности: ");
    int numberOfElements = int.Parse(Console.ReadLine());
    Console.Write($"Последовательность чисел Фибоначчи: {firstNumber} {secondNumber} ");
    FibonacciSequence(firstNumber, secondNumber, numberOfElements - 2);
    Console.ReadKey();
}
void FibonacciSequence(int firstNumber, int secondNumber, int elements)
{
    if (elements == 0) return;
    int thirdNumber = firstNumber + secondNumber;
    Console.Write($"{thirdNumber} ");
    FibonacciSequence(secondNumber, thirdNumber, elements - 1);
}

Main();
