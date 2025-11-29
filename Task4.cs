class Task4Calculator

{
    static void Main()
    {
        char choice = 'Y';
while (choice == 'Y' || choice == 'y')
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            
            Console.Write("Enter your choice: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value 1:");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value2:");
            double value2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            string symbol = "";

            switch (operation)

            {
                case 1:
                result = value1 + value2;
                symbol = "+";
                break;

                case 2:
                result = value1 -value2;
                symbol = "-";
                break;

                case 3:
                result  = value1 * value2;
                symbol ="*";
                break;

                case 4:
                result = value1 / value2;
                symbol = "/";
                break;

                default:
                Console.WriteLine("Invalid choice. Plese select 1-4 only.");
                continue; // restart loop

           }
              Console.WriteLine($" {value1}{symbol}{value2} = {result}");

              Console.Write("Do you want to continue (Y/N):");
              choice = Convert.ToChar(Console.ReadLine());

               }
               Console.WriteLine("Program ended. Thank you!");
               
    }
}
