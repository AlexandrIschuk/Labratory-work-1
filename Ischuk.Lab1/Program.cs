namespace Ischuk.Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чему равно значение функции: F = sin^2(log5(b)/sqrt(cos(2a))");
            double a = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                Console.Write("Введите число A: ");
                Console.Write("Введите число A: ");
                isNumber = double.TryParse(Console.ReadLine(), out a);
                if (!isNumber)
                {
                    Console.WriteLine("Вы ввели не число!");
                }
            }
            double b = 0;
            bool isNumberB = false;
            while (!isNumberB)
            {
                Console.Write("Введите число B: ");
                isNumberB = double.TryParse(Console.ReadLine(), out b);
                if (!isNumberB)
                {
                    Console.WriteLine("Вы ввели не число!");
                }
            }
            double s1 = Math.Log(b, 5);
            double s2 = Math.Sqrt(Math.Cos(2 * a));
            double result = Math.Pow(Math.Sin(s1 / s2), 2);
            Console.WriteLine("Ответ: " + result);
            Console.ReadKey();
        }
    }
}