namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string input = Console.ReadLine();
            bool result = IsPalindrome(input);
            Console.WriteLine(input + " IsPalindrome : " + result);

            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumbers = { 28, 16, 75, 28, 1 };

            string compare = Compare(arrayNumbers, number);
            if (compare == "")
                Console.WriteLine("Not Found!");
            else
                Console.WriteLine("Output: " + compare);
            Console.ReadKey();
        }

        static bool IsPalindrome(string input)
        {
            string palindrome = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                palindrome += input[i];
            }

            return input == palindrome ? true : false;
        }
        static string Compare(int[] array, int number)
        {
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == number)
                    {
                        result = result + "[" + i + " , " + j + "]";
                        break;
                    }
                }
            }

            return result;
        }
    }
}