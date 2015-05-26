using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz_CodeKata
{
    public class FizzBuzz
    {
        public string DoFizzBuzz(int number)
        {
            if(DivisibleByThree(number) && DivisibleByFive(number))
            {
                return "FizzBuzz";
            }
            else if (DivisibleByThree(number))
            {
                return "Fizz";
            }
            else if (DivisibleByFive(number))
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
            
        }

        private bool DivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

        public bool DivisibleByThree(int number)
        {
            //using modulo to figure out multiple
            return number % 3 == 0;
        }
    }
}
