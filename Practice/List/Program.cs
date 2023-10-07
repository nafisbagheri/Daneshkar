using System.Data.Common;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods Methods = new Methods();
            List<long> mylist = new List<long> { 10, 16, 5, 3, 1, 64, 20 };
            
            bool find = Methods.IsDuplicate(mylist);
            if (find)
                Console.WriteLine("The list has duplicate numbers!");
            else
                Console.WriteLine("The list has not duplicate numbers!");
            string reverse = "";
            List<long> result = Methods.Reverse(mylist);
            foreach (int i in result)
            {
                reverse += i + ",";
            }
            Console.WriteLine("reverse = {" + reverse + "}");
            long secondLargestNumber = Methods.SecondMaxNumber(mylist);
            Console.WriteLine("The Second Max Number Is:" + secondLargestNumber);
            Console.ReadKey();
        }
    }
}