

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            Calc compute = new Calc();
            double[] values = new double[2];
            double memory = 0;
            bool temp = false;
            int action;

            do
            {

                if(memory != 0)
                {
                    Console.WriteLine("\nUse last calculation's result?\nENTER IF NO, TYPE ANYTHING FOR YES.\n");
                    string input = Console.ReadLine() ?? "";
                    if (!string.IsNullOrEmpty(input))
                    {
                        temp = true;
                        values[0] = memory;
                    }
                }

                if (!temp)
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
                while(!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.Write("Enter a valid number: ");
                }

                switch (action)
                {
                    case 1:
                        memory = compute.sum(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    case 2:
                        memory = compute.difference(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    case 3:
                        memory = compute.product(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    case 4:
                        memory = compute.quotient(values[0], values[1]);
                        Console.WriteLine("Result: " + memory);
                        break;
                    default:
                        Console.WriteLine("Invalid operation!\n"); break;
                }

                temp = false;

            } while(true);

        }

    }
}
