using System.Linq;


namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            int amount = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            
            var generator = new RandomGenerator();
            var nums = generator.RandomNumbers(amount, min, max);
            Console.Write($"Here is {amount.ToString()} random numbers between {min.ToString()} and {max.ToString()}: {string.Join(" ", nums)}");
        }
    }

    class RandomGenerator
    {
        private readonly Random random = new Random();

        public List<int> RandomNumbers(int num, int min, int max)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < num; i++)
            {
                nums.Add(random.Next(min, max));
            }

            return nums;
        }
    }
}

