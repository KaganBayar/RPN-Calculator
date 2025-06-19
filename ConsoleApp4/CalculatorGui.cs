using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class CalculatorGui
    {
        private Calculator calculator;

        public void Start()
        {
               
            Console.Clear();
            Console.WriteLine("RPN Calculator");
            Console.WriteLine("Enter expressions in Reverse Polish Notation (e.g., '3 4 +')");
            Console.WriteLine("Operators Are + - * /");
            Console.WriteLine("Type 'quit' to exit");
            while (calculator.input != "quit")
            {
                calculator.input = Console.ReadLine();
                Console.WriteLine(calculator.Calculate());
                
            }
        }

    
        public CalculatorGui(Calculator calculator)
        {
            this.calculator = calculator;
        }
    }
}
