namespace ConsoleApp1.Tasks
{
    class Task2
    {
        static void Main()
        {
            // Step 2: Declare and initialize the jagged 2D array
            int[][] numberMatrix = new int[][]
            {
                new int[] { 2, 4, 6, 8, 10 }, // Row 0: Even numbers
                new int[] { 1, 3, 5, 7, 9 }   // Row 1: Odd numbers
            };

            Console.WriteLine("The number matrix has been initialized.");

            // Step 4: Extract digits based on clues
            int digit1 = numberMatrix[1][3]; // Row 1, Index 3
            int digit2 = numberMatrix[0][0]; // Row 0, Index 0
            int digit3 = numberMatrix[1][4]; // Row 1, Index 4

            // Step 5: Combine digits into a key
            string password = $"{digit1}{digit2}{digit3}";

            // Step 7: Display the password
            Console.WriteLine($"The 3-digit password is: {password}");
        }
    }
}
