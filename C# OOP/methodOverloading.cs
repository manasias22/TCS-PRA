using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloadingDemo
{
    class Calculator
    {
        // Two int type parameters method
        public int Add(int x, int y)
        {
            return x + y;
        }
        // Three int type parameters method
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        // Two float type parameters method
        public float Add(float x, float y)
        {
            return x + y;
        }
        // Three float type parameters method
        public float Add(float x, float y, float z)
        {
            return x + y + z;
        }
    }
    class CalculatorDemo
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            // Calling the overloaded methods
            int result1 = calculator.Add(10, 20);
            int result2 = calculator.Add(10, 20, 30);
            float result3 = calculator.Add(10.5f, 20.3f);
            float result4 = calculator.Add(10.5f, 20.3f, 30.7f);
            // Displaying the results
            Console.WriteLine("Result of adding two integers: " + result1);
            Console.WriteLine("Result of adding three integers: " + result2);
            Console.WriteLine("Result of adding two floats: " + result3);
            Console.WriteLine("Result of adding three floats: " + result4);
            Console.ReadLine();
        }
    }
}