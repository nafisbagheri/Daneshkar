using System.Data.Common;
namespace List
{
    public class Methods
    {
        public bool IsDuplicate(List<long> numbers)
        {
            bool IsDuplicate = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        IsDuplicate = true;
                        break;
                    }
                }
            }

            return IsDuplicate;
        }
        public List<long> Reverse(List<long> numbers)
        {
            List<long> reverse = new List<long>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                reverse.Add(numbers[i]);
            }
            return reverse;
        }
        public long SecondMaxNumber(List<long> numbers)
        {
            long largest = 0;
            long second = 0;
            foreach (int item in numbers)
            {
                if (item > largest)
                {
                    second = largest;
                    largest = item;
                }
                else if (item > second)
                    second = item;
            }

            return second;
        }
    }
}
