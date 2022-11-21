using System.Linq;


namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            
            var generator = new RandomGenerator();
            var nums = generator.RandomNumbers(5, 2, 55);
            Console.Write($"Random numbers between 2 and 5: {string.Join(" ", nums)}");
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

