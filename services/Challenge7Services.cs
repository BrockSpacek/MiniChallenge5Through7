using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ObjectPool;

namespace MiniChallenge5Through7.services
{
    public class Challenge7Services
    {
        public string reverseNumber(string inputNumber)
        {
            int temp;
            int remainder;
            int reverseInt = 0;
            int convertedNumber;



            bool validInput = int.TryParse(inputNumber, out convertedNumber);

            if (validInput == false)
            {
                return "That is not a valid response, Please enter in a number!";
            }

            if (convertedNumber == 0 || convertedNumber == 00 || convertedNumber == 000)
            {
                return "Must enter valid input that is not 0";

            }
            else if (convertedNumber != 0)
            {
                temp = convertedNumber;
                while (convertedNumber > 0)
                {
                    remainder = convertedNumber % 10;
                    reverseInt = reverseInt * 10 + remainder;
                    convertedNumber /= 10;
                }

                return $"{temp}\n{reverseInt}";
            }
            else
            {
                return "How did you get here! Just enter a number";
            }

        }
    }
}