using System.Linq;


namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            try
            {
                int amount;
                int min;
                int max;
                while (true)
                {
                    Console.WriteLine("Enter amount of random numbers: ");
                    bool amountSuccess = int.TryParse(Console.ReadLine(), out amount);
                    Console.WriteLine("Enter minimum random number value: ");
                    bool minSuccess = int.TryParse(Console.ReadLine(), out min);
                    Console.WriteLine("Enter maximum random number value: ");
                    bool maxSuccess = int.TryParse(Console.ReadLine(), out max);
                
                    if (amountSuccess && minSuccess && maxSuccess)
                    {
                        var generator = new RandomGenerator();
                        var nums = generator.RandomNumbers(amount, min, max);
                        Console.Write($"Here is {amount.ToString()} random numbers between {min.ToString()} and {max.ToString()}: {string.Join(" ", nums)}");
                        break;
                    }

                    Console.WriteLine("One of your inputs were invalid, please try again.");

                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

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

