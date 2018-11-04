﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTool
{
    public class Calculator
    {
        /**
         * A special number is any number that is 
         *  - is between 0 and 100 inclusive and
         * 	- divisible by two and
         * 	- divisible by five.
         * @param number
         * @return message (that displays if the number is a special number) 
         */
        public String IsSpecialNumber(int number)
        {
            String message = "";

            // Verify the number is within the valid range.
            if (number < 0 || number > 100)
            {
                message = " is not a valid number.";
            }
            else
            {
                // Determine if the number is a special number.
                if (number % 2 != 0)
                {
                    message = " is not an even number.";
                }
                else if (number % 5 != 0)
                {
                    message = " is not divisible by five.";
                }
                else
                {
                    message = " is a special number";
                }
            }
            return number + message;
        }


        /**
         * This method does a special calculation
         * @param operand
         * @return BigDecimal
         */
        public Decimal AlternativeCalculate(double operand)
        {

            double calculatedValue = operand * 100 / Math.PI;

            Decimal ret = (Decimal)calculatedValue;

            return ret;
        }

    }
}
