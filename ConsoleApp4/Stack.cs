using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Stack
    {
        private List<Operand> items;
        public int Count => items.Count;
        private Calculator calculator;
        
        public Operand Push(Operand item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Cannot push null onto the stack");
            }
            items.Add(item);
            
            return item;
        }
        public Operand Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack");
            }
            var item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }
        public Operand Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot peek at an empty stack");
            }
            return items[items.Count - 1];
        }

        public Stack(Calculator calculator)
        {
            this.calculator = calculator;
            items = new List<Operand>();
  
        }
    }
}
