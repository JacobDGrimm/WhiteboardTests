using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardTests
{
    class Program
    {
        static void Main(string[] args)
        {

            // given an array of ints total together all the even numbers

            int[] numarr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sum = 0;

            for (int i = 0; i < numarr.Length; i++)
            {
                if (numarr[i] % 2 == 0)
                {
                    sum += numarr[i];
                }
            }

            Console.WriteLine(sum);
            
            
            
            
            // given a string "foo bar foo $ bar $ foo bar $, write a program that removes the 2nd and third $

            string input = "foo bar foo $ bar $ foo bar $";

            char[] arr = input.ToCharArray();

            bool notFirst = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '$' )
                {
                    if (notFirst == true)
                    {
                        arr[i] = ' ';
                    }
                    notFirst = true;
                }
            }

            string output = new string(arr);
            Console.WriteLine(output);

            // calculate the nth number of the ol' fib sequence

            int n = 20; // this is the target sequence number

            int onum = 1; // this is a value to hold the original number for this section of the sequence
            int num = 1; // this is the current number in the sequence
            int pnum = 0; // this is the previous number it starts set to zero because the first number before one is zero
            int ncount = 1; // this is a counter

            while(ncount < n)
            {
                num += pnum;
                pnum = onum;
                onum = num;
                ncount++;
            }

            Console.WriteLine(num);
        }
    }
}
