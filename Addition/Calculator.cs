using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Calculator
    {
        public dynamic Add(dynamic operand1, dynamic operand2)
        {
            return operand1 + operand2;
        }

        public dynamic Sub(dynamic operand1, dynamic operand2)
        {
            return operand1 - operand2;
        }

        public dynamic Mul(dynamic operand1, dynamic operand2)
        {
            return operand1 * operand2;
        }

        public dynamic Div(dynamic operand1, dynamic operand2)
        {
            if (operand2 != 0)
            {
                return operand1 / operand2;
            }
            else
            {
                return "На 0 делить нельзя.";
            }

        }

    }
}
