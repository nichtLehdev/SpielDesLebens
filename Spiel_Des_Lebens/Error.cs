using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    class Error : Exception
    {
        public Error(string message)
        : base(message)
        {
            Console.WriteLine( "ERROR - " + message);
        }
    }
}
