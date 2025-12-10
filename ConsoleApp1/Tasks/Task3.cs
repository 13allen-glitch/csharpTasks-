namespace ConsoleApp1.Tasks
{
    class Task3
    {
        static void Main()
        {
            int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

            Console.Write("Enter a number to search for: ");

            int target;
            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.Write("Invalid number. Enter again: ");
            }

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine($"Number found at position {i}!");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Number not found in the list.");
            }

            Console.ReadKey();
        }
    }
}
