using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Assignment
{
    //Creating the class
    public class MathOperations
    {   
        //Creating the methods start
        public int add(int num1)
        {
            int result = num1 + 250;
            return result;
        }

        public int div(int num1)
        {
            int result = num1 / 3;
            return result;
        }

        public int multi(int num1)
        {
            int result = num1 * 100;
            return result;
        }

        public int avOfAll(int num1, int num2, int num3) 
        {
            int result = (num1 + num2 + num3) / 3;
            return result;
        }
        //Creating the methods end
    }
}
