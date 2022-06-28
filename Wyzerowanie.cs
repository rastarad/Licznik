using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licznik
{
    internal class Wyzerowanie
    {
        internal static async Task Zeruj(List<string> lista, ConsoleKeyInfo liczba)
        {
            await PracaZPlikiem.Wyswietl();
            Console.WriteLine("\nCzy na pewno chcesz wyczyścić dany plik txt? - 'y'");
            liczba = Console.ReadKey(true);
            while (true)
            {
                if (liczba.Key == ConsoleKey.Y)
                {
                    await PracaZPlikiem.Usun();
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
