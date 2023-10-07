namespace CalculatorSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number1:");
            string op1 = Console.ReadLine();

            Console.WriteLine("operation:");
            var operation = Console.ReadLine();

            Console.WriteLine("Number2:");
            string op2 = Console.ReadLine();

            if (!CheckValid(op1, op2, operation))
                return;

            long? result = 0;
            switch (operation)
            {
                case "*":
                    result = Convert.ToInt64(op1) * Convert.ToInt64(op2);
                    break;
                case "/":
                    result = Convert.ToInt64(op1) / Convert.ToInt64(op2);
                    break;
                case "+":
                    result = Convert.ToInt64(op1) + Convert.ToInt64(op2);
                    break;
                case "-":
                    result = Convert.ToInt64(op1) - Convert.ToInt64(op2);
                    break;
            }

            Console.WriteLine(op1 + "" + operation + "" + op2 + "=" + result);
            Console.ReadKey();
        }

        static bool CheckValid(string op1, string op2, string operation)
        {
            if (!(operation == "*" || operation == "/" || operation == "+" || operation == "-"))
            {
                Console.WriteLine("The operation is not valid!Allowed operations:* or / or + or -");
                return false;
            }
            if (!long.TryParse(op1, out long num1) || !long.TryParse(op2, out long num2))
            {
                Console.WriteLine("The input is invalid!Please enter a number");
                return false;
            }
            return true;
        }
    }
}