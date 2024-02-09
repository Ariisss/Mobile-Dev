class Calculator
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Subtract(double x, double y)
    {
        return x - y;
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

    public double Divide(double x, double y)
    {
        return x / y;
    }

    public void Menu()
    {
        Console.WriteLine("Operations:");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        Console.Write("Choice: ");
    }

    public void AskInteger(ref int option)
    {
        while (!int.TryParse(Console.ReadLine(), out option))
        {
            Console.Write("Invalid input. Please enter a valid option: ");
        }
    }

    public void AskDouble(ref double operand)
    {
        while (!double.TryParse(Console.ReadLine(), out operand))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }
    }

}

class Program
{
    static void Main()
    {
        bool isRunning = true;
        bool isRemembered = false;
        Calculator calculator = new Calculator();
        int option = 0;
        double left = 0;
        double right = 0;

        do
        {
            if (!isRemembered)
            {
                Console.Write("Enter the first operand: ");
                calculator.AskDouble(ref left);
            }

            isRemembered = false;

            Console.Write("Enter the second operand: ");
            calculator.AskDouble(ref right);

            calculator.Menu();
            calculator.AskInteger(ref option);

            int isSucessful = 0;

            switch (option)
            {
                case 1:
                    isSucessful = 1;
                    left = calculator.Add(left, right);
                    Console.WriteLine("Sum: " + left);
                    break;
                case 2:
                    isSucessful = 2;
                    left = calculator.Subtract(left, right);
                    Console.WriteLine("Difference: " + left);
                    break;
                case 3:
                    isSucessful = 3;
                    left = calculator.Multiply(left, right);
                    Console.WriteLine("Product: " + left);
                    break;
                case 4:
                    isSucessful = 4;
                    left = calculator.Divide(left, right);
                    Console.WriteLine("Quotient: " + left);
                    break;
                default:
                    Console.WriteLine("Invalid input. Operation does not exist!");
                    break;
            }

            if (isSucessful > 0)
            {
                string message = "result";

                switch (isSucessful)
                {
                    case 1:
                        message = "sum";
                        break;
                    case 2:
                        message = "difference";
                        break;
                    case 3:
                        message = "product";
                        break;
                    case 4:
                        message = "quotient";
                        break;
                }

                Console.WriteLine("Do you want to use the previous " + message + "? (y/n)");

                string input;
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write("Please enter 'y' or 'n': ");
                    input = Console.ReadLine() ?? "";

                    if (input == "y" || input == "n")
                    {
                        validInput = true;
                        if (input == "y")
                        {
                            isRemembered = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }
                }
            }
        } while (isRunning);
    }
}
