namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double memory = 0;
            bool useMemory = false;
            double[] values = new double[2]; 
            Calc compute = new Calc();
            int action;

            do
            {
                // What if the result of the previous result was 0?
                if (memory != 0)
                {
                    Console.WriteLine("\nUse last calculation's result?\nENTER IF NO, TYPE ANYTHING FOR YES.\n");
                    string input = Console.ReadLine() ?? "";

                    if (!string.IsNullOrEmpty(input))
                    {
                        useMemory = true;
                        values[0] = memory;
                    }
                }

                if (!useMemory)
                {
                    Console.Write("Choose 1st Operand: ");

                    while (!double.TryParse(Console.ReadLine(), out values[0]))
                    {
                        Console.Write("Invalid operand, choose a valid number: ");
                    };
                }

                Console.Write("Choose 2nd Operand: ");

                while (!double.TryParse(Console.ReadLine(), out values[1]))
                {
                    Console.Write("Invalid operand, choose a valid number: ");
                }

                Console.WriteLine("\nOperations:");
                Console.WriteLine("1.) Addition");
                Console.WriteLine("2.) Subtraction");
                Console.WriteLine("3.) Multiplication");
                Console.WriteLine("4.) Division");
                Console.WriteLine("Invalid operation will restart the app.");
                Console.Write("\nChoice: ");

                while (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.Write("Enter a valid number: ");
                }

                switch (action)
                {
                    case 1:
                        memory = compute.Sum(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    case 2:
                        memory = compute.Difference(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    case 3:
                        memory = compute.Product(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    case 4:
                        memory = compute.Quotient(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    default:
                        Console.WriteLine("Invalid operation!\n"); break;
                }

                useMemory = false;
            } while (true);
        }
    }
}
