using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licznik
{
    internal static class Zapis
    {
        internal static async Task Zapisz(List<string> lista, ConsoleKeyInfo liczba)
        {
            await PracaZLista.PokazListe(lista);
            await PracaZPlikiem.Wyswietl();
            Console.WriteLine("\nCzy na pewno chcesz zapisać do pliku daną listę txt? - 'y'");
            liczba = Console.ReadKey(true);
            while (true)
            {
                if (liczba.Key == ConsoleKey.Y)
                {
                    await PracaZPlikiem.Dodaj(lista);
                    break;
                }
                else if (liczba.Key != ConsoleKey.Y)
                {
                    break;
                }
            };
            Console.Clear();
        }
    }
}
