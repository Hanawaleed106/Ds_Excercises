namespace Tasks
{
    internal class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Subtract");
            Console.WriteLine("3- Multiply");
            Console.WriteLine("4- Divide");
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    break;
                case 4:
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine($"Result = {result}");

            //********************************************************************************************
            // Exercise 2
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Original Name: {name}");
            Console.WriteLine($"Uppercase: {name.ToUpper()}");
            Console.WriteLine($"Lowercase: {name.ToLower()}");
            Console.WriteLine($"Length: {name.Length}");
            Console.WriteLine($"Trimmed Name: {name.Trim()}");
            //*******************************************************************************************
            //Excersise 3
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            if (email.EndsWith("@gmail.com"))
            {
                Console.WriteLine("Valid Gmail");
            }
            else
            {
                Console.WriteLine("Not a valid Gmail address");
            }
            //******************************************************************************
            //Exsercise 4
            string[] array = new string[5];

            for (int i = 0; i <array.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNames in Uppercase:");
            foreach (string n in array)
            {
                Console.WriteLine(n.ToUpper());
            }

            //********************************************************************************
            // Exercise 5
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            foreach (int num in numbers)
            {
                string parity = (num % 2 == 0) ? "Even" : "Odd";
                Console.WriteLine($"{num} is {parity}");
            }

            //************************************************************************
            // Excersice 6

            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;

                if (num > max)
                    max = num;

                if (num < min)
                    min = num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"\nSum = {sum}");
            Console.WriteLine($"Average = {average}");
            Console.WriteLine($"Largest Number = {max}");
            Console.WriteLine($"Minimum Number = {min}");
        }
    }
}
