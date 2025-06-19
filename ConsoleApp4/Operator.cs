using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class Operator : Calculator
    {
        Operand operand1;
        Operand operand2;
     
       
        public abstract Operand Execute(Operand operand1, Operand operand2);
    }
}
