using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            // without altering any of the code in Main() write code that satisfies the examples below: 
		
            /*
                ====== Remove Extra Chars ======
                Return a string where the number of consecutive characters of the same value is limited to the parameter supplied
            */
		
            // should return "aabbccdde" - only a maximum of 2 of the same character next to each other
            Console.WriteLine("aaabbcccccdddde".RemoveConsecutiveChars(2));
		
            /*
                ====== Fizz Buzz ======
                Should return each number between zero and its parameter (inclusive) but replaces multiples of 3 with "Fiz" and multiples of 5 with "Buz"
                Where the number of 'z' characters in each word is the same as the other factor of the input number
                For multiples of both 3 and 5 replace the number with both of the corresponding "Fiz-Buz" words.
                e.g. 15 shoud be replaces with "Fizzzzz-Buzzz"
            */

            //foreach(var s in FizzBuzz(100))
            //{
            //    Debug.WriteLine(s);
            //}

            Console.ReadKey();
        }
    }
}
