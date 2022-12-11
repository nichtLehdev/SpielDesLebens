// @author: Kevin Kern
// Error class for the game. 

using System;

namespace SpielDesLebens
{
    internal class Error : Exception
    {
        public Error(string message)
        : base(message)
        {
            Console.WriteLine("ERROR - " + message);
        }
    }
}
