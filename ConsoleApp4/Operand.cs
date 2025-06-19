using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Operand : Calculator
    {
        private double value;
        public double Value 
        {
            get { return value; }
            set
            {
                this.value = value;
            }
        }
          public Operand(double value)
            {
              this.Value = value;
            }



    }

}
