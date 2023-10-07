
namespace StackSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stack stack = new stack();

            long[] nums = new long[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 ,5,6,6,7,8};
            string numstr=string.Join(",", nums);
            long result = stack.CountOfUniqueItems(nums);
            Console.WriteLine("CountOfUniqueItems in mystack("+numstr+"):"+ result);
            char[] input = new char[] { '(', ')' };
            bool Isvalid = stack.IsValid(input);
            string inputStr = "";
            inputStr = string.Join(" ", input);
            Console.WriteLine(inputStr + " **Is valid:" + Isvalid.ToString()+" **");
            input = new char[] { '(', ')', '[', ']', '{', '}' };
            Isvalid = stack.IsValid(input);
            inputStr = string.Join(" ", input);
            Console.WriteLine(inputStr + " **Is valid:" + Isvalid.ToString()+" **");
            input = new char[] { '(', ']' };
            Isvalid = stack.IsValid(input);
            inputStr = string.Join(" ", input);
            Console.WriteLine(inputStr + " **Is valid:" + Isvalid.ToString()+" **");
            input = new char[] { '(', '[', ']', ')', '[', ']', '{', '(', ')', '}' };
            Isvalid = stack.IsValid(input);
            inputStr = string.Join(" ", input);
            Console.WriteLine(inputStr + " **Is valid:" + Isvalid.ToString()+" **");
            Console.ReadKey();
        }
    }
}