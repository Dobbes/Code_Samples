
//Input Description
//You will be given two integers, N and M, on standard console input. They will be space delimited values where 
//N will range from 1 to 9, and M will range from 2 to 999,999,999.

//Output Description
//Print the largest integer within the range of 1 to the largest integer formed by N-digits, that is 
//evenly-divisible by the integer M. You only need to print the largest integer, not the set of evenly-divisible 
//integers. If there is no solution, print "No solution found".

//Sample Inputs & Outputs
//Sample Input 1
//3 2
//Sample Output 1
//998
//Sample Input 2
//7 4241275
//Sample Output 2
//8482550


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arithmetic_Program
{
class Program
{
    static void Main(string[] args)
    {
        //Creating 'M'
     int Modulo = new Random().Next(1, 9);
     
        //Creating 'N'   
     int NumeratorDigits = new Random().Next(2, 10);

        //Making 'M' Appropriate Length
        long Numerator = (long)Math.Pow(10, NumeratorDigits) - 1;

        Console.WriteLine("Modulo: " + Modulo);
        Console.WriteLine("Numerator: " + Numerator);

        int i = 0;

        //Printing desired output
        while (Numerator % Modulo != 0)
        {
            i++;
            Numerator = Numerator - i;
            if (Numerator < Modulo)
            {
                Console.WriteLine("No Solution");
                goto End;
            }
        }

        Console.WriteLine("Answer: " + Numerator);

        End:
        Console.ReadLine();


    }
}
}