using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ObjectPool;
using MiniChallenge5Through7.Controllers;

namespace MiniChallenge5Through7.services
{
    public class Challenge7ServicesPart2
    {
        public string reverseString(string password){

            string reversePassword = "";

            for (int i = password.Length - 1; i >= 0; i--)
        {
            reversePassword += password[i];

        }

        return $"{password}\n{reversePassword}";
        }
    }
}