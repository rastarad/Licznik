using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licznik
{
    internal static class Odczyt
    {
        internal static async Task Wczytaj(List<string> lista, ConsoleKeyInfo liczba)
        {
            List<string> lista3 = new List<string>();
            await PracaZLista.PokazListe(lista);
            await PracaZPlikiem.Zaladuj(lista3);
            MessageBox.Message();
            Console.WriteLine("\nCzy na pewno chcesz wczytać plik do listy? - 'y'");
            liczba = Console.ReadKey(true);
            while (true)
            {
                if (liczba.Key == ConsoleKey.Y)
                {
                    MessageBox.DodajMessage("!!! Plik został załadowany do bieżącej listy !!!");
                    lista.Clear();
                    lista3.ForEach(s=> lista.Add(s));
                    PracaZLista.PokazListe(lista);
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
