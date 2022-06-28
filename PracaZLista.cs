using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licznik
{
    internal class PracaZLista
    {
        public static async Task PokazListe(List<string> lista)
        {
            Console.WriteLine("\n--- Bieżąca lista: ---");
            if (lista.Any())
            {
                lista.ForEach(l => Console.Write(l + " "));
            }
        }
    }
}
