using System;
using System.Security.Cryptography.X509Certificates;
using static System.Collections.Specialized.BitVector32;

namespace Calculator
{
    internal class Calc
    {
        public string? result;
        private double ret = 0;
        public void testConsole()
        {
            Console.WriteLine("TESTING");
        }

        public double sum(double x, double y)
        {
            ret = x + y;
            result = ret.ToString("F2");
            return ret;
        }
        
        public double product(double x, double y)
        {
            ret = x * y;
            result = ret.ToString("F2");
            return ret;
        }

        public double quotient(double x, double y)
        {
            ret = x * y;
            result = ret.ToString("F2");
            return ret;
        }

        public double difference (double x, double y)
        {
            ret = x - y;
            result = ret.ToString("F2");
            return ret;
        }

        // public string Result() 
        // {
        //     if(this.result != null)
        //     {
        //         return this.result;
        //     }
        //     return "Result is null";
        // }

    }
}
