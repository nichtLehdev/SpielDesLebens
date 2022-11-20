using System;

namespace Spiel_Des_Lebens
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
