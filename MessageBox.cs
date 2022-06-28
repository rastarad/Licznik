using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licznik
{
    internal static class MessageBox
    {
        static string message = "";
        internal static async Task Message()
        {
            Console.WriteLine("\n");
            Console.WriteLine(message);
            message = "";
        }
        internal static async Task DodajMessage(string dodMessage)
        {
            message = dodMessage;
        }
    }
}
