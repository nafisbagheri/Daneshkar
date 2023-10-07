namespace FibonacciFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = 0;
            Console.WriteLine("Enter Number:");
            number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Fibonacci(" + number + ")=" + (Fibonacci(number).ToString()));
            Console.ReadKey();
        }
        static long Fibonacci(long count)
        {
            if (count == 1 || count == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(count - 2) + Fibonacci(count - 1);
            }
        }
    }
}