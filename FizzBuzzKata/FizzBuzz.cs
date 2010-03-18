
using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string StringFor(int number)
        {
            ThrowExceptionIfNumberIsOutOfRange(number);

            if (IsDivisibleByThree(number) && IsDivisibleByFive(number))
            {
                return "fizzbuzz";
            }
            else if (IsDivisibleByThree(number))
            {
                return "fizz";
            }
            else if (IsDivisibleByFive(number))
            {
                return "buzz";
            }
            else 
            {
                return number.ToString();
            }
        }

        private void ThrowExceptionIfNumberIsOutOfRange(int number)
        {
            if(number < 1)
            {
                throw new ArgumentOutOfRangeException("number", number, "Number must be greater than 0");
            }
            else if (number > 100)
            {
                throw new ArgumentOutOfRangeException("number", number, "Number must be less than 101");
            }
        }

        private bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

        private bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}
