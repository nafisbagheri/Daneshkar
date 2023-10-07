namespace FactorialFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            long inputNumber = Convert.ToInt64(Console.ReadLine());
            long factorial = Factorial(inputNumber);
            Console.WriteLine("Factorial ("+inputNumber+")= " + factorial);
            Console.ReadKey();
        }
        static long Factorial(long input)
        {
            if (input == 0)
                return 1;
            else
                return input * Factorial(input - 1);
        }
    }
}