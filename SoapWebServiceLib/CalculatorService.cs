using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapWebService
{
    public class CalculatorService : ICalculator
    {
        private const string opMsg = "Received: {0}({1},{2})\nReturn: {3}";

        public double Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine(string.Format(opMsg, "Add", a, b, result));
            return result;
        }

        public double Divide(double a, double b)
        {
            double result = a / b;
            Console.WriteLine(string.Format(opMsg, "Divide", a, b, result));
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            Console.WriteLine(string.Format(opMsg, "Multiply", a, b, result));
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            Console.WriteLine(string.Format(opMsg, "Subtract", a, b, result));
            return result;
        }
    }
}