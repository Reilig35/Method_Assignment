using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the user to pass in number to functions start
            Console.WriteLine("Please type in a number to add 250 to:\n");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in a number to divide by 3:\n");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in a number to multiply by 100:\n");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            //Getting the user to pass in number to functions start

            //Calling on the functions to execute start
            MathOperations addOn = new MathOperations();
            var Result1 = addOn.add(userInput1);

            MathOperations divBy = new MathOperations();
            var Result2 = divBy.div(userInput2);

            MathOperations multiply = new MathOperations();
            var Result3 = multiply.multi(userInput3);

            MathOperations ave = new MathOperations();
            var Result4 = ave.avOfAll(Result3, Result2, Result1);
            //Calling on the functions to execute start

            //Print out the results in the console start
                Console.WriteLine($"{userInput1} + 250 = {Result1}" +
                $"\n\n\n{userInput2} / 3 = {Result2}" +
                $"\n\n\n{userInput3} * 100 = {Result3}" +
                $"\n\n\nThe average of the results is {Result4}" );
            //Print out the results in the console end

        }

    }
}
