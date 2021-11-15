using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Given the following code, change the code to implement
             * A. Inferred Typing
             * B. String Interpolation
             * C. Ternary Operator
             */

            int answer = 4; //Assigning answer value

            //Set response value: var response =
            //Check if the answer value is lesser than 9: (answer < 9 )
            //Declare message if it lesser than or greater than 9: ? $"{answer} is greater than or equal to nine" : $"{answer} is less than nine"
            var response = (answer < 9 ) ? $"{answer} is greater than or equal to nine" : $"{answer} is less than nine"; 
            
            //Output message
            Console.WriteLine(response);
            Console.ReadLine();

            //Inferred Typing: var response =
            //String Interpolation: $"{answer} is greater than or equal to nine" : $"{answer} is less than nine"
            //Ternary Operator: (answer < 9 ) ?
        }
    }
}
