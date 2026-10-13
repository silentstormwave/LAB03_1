namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма:{a + b}");
            Console.WriteLine($"Разность:{a - b}");
            Console.WriteLine($"Произведение:{a * b}");
            Console.WriteLine($"Среднее арифмитическое:{(a + b)}");
        }
    }
}
