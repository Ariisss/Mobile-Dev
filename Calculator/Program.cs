namespace Calculator;

class Program
{
    static int Main(string[] args)
    {
        int argc = args.Length;

        if (argc == 0)
        {
            Console.WriteLine("For more information, try 'help'");
            return 1;
        }
        else if (argc > 3)
        {
            Console.WriteLine("Too many arguments");
            return 1;
        }
        else if (argc == 1)
        {
            if (args[0] == "help")
            {
                Console.WriteLine("Work in progress...");
                return 0;
            }
            else
            {
                Console.WriteLine("For more information, try 'help'");
                return 1;
            }
        }

        int left = Convert.ToInt32(args[0]);
        int right = Convert.ToInt32(args[2]);
        int result = 0;

        switch (args[1])
        {
            case "+":
                result = left + right;
                Console.Write(result);
                break;
            case "-":
                result = left - right;
                Console.Write(result);
                break;
            case "*":
                result = left * right;
                Console.Write(result);
                break;
            case "/":
                result = left / right;
                Console.Write(result);
                break;
            default:
                Console.WriteLine("For more information, try 'help'");
                return 1;
        }

        return 0;
    }
}
