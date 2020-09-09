using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculateProject
{
    public class Calculate
    {
        public double Addition(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        public double Multiplication(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }

        public double Divison(double numberOne, double numberTwo)
        {
            return numberTwo != 0 ? numberOne / numberTwo : 0;
        }

        public double Modulo(double numberOne, double numberTwo)
        {
            return numberOne % numberTwo;
        }

        public double Substraction(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }
    }
    
}
