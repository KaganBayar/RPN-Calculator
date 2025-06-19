using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Divider : Operator
    {
        public override Operand Execute(Operand operand1, Operand operand2)
        {
            if (operand1 == null || operand2 == null)
                throw new ArgumentNullException("Operands cannot be null");

            return new Operand(operand1.Value / operand2.Value);
        }
    }
}
