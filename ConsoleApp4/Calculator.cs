using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Calculator
    {
        public string input { get; set; }
        private Stack Stack;
        public CalculatorGui Gui;
        private List<string> operators = new List<string> { "+", "-", "*", "/"};



        public double Calculate()
        {
            if(Stack.Count > 0)
            {
                Stack = new Stack(this); // Reset the stack for a new calculation
            }
            if (string.IsNullOrEmpty(input) || input.ToLower() == "quit")
            {
                return 0;
            }
            string[] tokens = input.Split(' ');
            foreach (var token in tokens)
            {
                
                if (double.TryParse(token, out double number))
                {  
                    
                    Stack.Push(new Operand(number));
                }
                else if(operators.Contains(token))
                {
                    // Pop the last two operands from the stack
                    if (Stack.Count < 2)
                    {
                        throw new InvalidOperationException("Not enough operands in the stack for operation.");
                    }
                    Operand operand2 = Stack.Pop();
                    Operand operand1 = Stack.Pop();
                    Operand result = new Operand(0);
                    switch (token)
                    {
                        case "+":
                            result = new Adder().Execute(operand1, operand2);
                            break;
                        case "-":
                            result = new Subtractor().Execute(operand1, operand2);
                            break;
                        case "*":
                            result = new Multiplier().Execute(operand2, operand1);
                            break;
                        case "/":
                            result = new Divider().Execute(operand1, operand2);
                            break;
                        default:
                            throw new InvalidOperationException($"Unknown operator: {token}");
                    }
                    // Calculate the result and push it back onto the stack
                    Stack.Push(result);
                }
                else
                {
                    throw new InvalidOperationException($"Invalid token: {token}");
                }
                {
            
                }
            }
            if (Stack.Count != 1)
            {
                throw new InvalidOperationException("Calculation did not result in a single value on the stack.");
            }
            else
            {
                return Stack.Peek().Value;
                
            }
            }
        public Calculator()
        {
            
            Stack = new Stack(this);
            Gui = new CalculatorGui(this);
        }
    }
}
