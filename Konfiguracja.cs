using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licznik
{
    internal static class Konfiguracja
    {
        internal static async Task Konfigurowanie(int suma, List<string> lista)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witaj w liczniku");
            Console.WriteLine("Aby dodać wpisz 'd'");
            Console.WriteLine("Aby odjąc wpisz 'o'");
            Console.WriteLine("Aby wyzerować wpisz 'r'");
            Console.WriteLine("Aby zapamiętać wpisz 'z'");
            Console.WriteLine("Aby zapomnieć wpisz 'x'");
            Console.WriteLine("Aby wyzerować listę wpisz 'u'");
            Console.WriteLine("Aby zapisać listę do pliku wpisz 's'");
            Console.WriteLine("Aby wczytać listę z pliku wpisz 'l'");
            Console.WriteLine("Aby wyzerować plik wciśnij 'delete'");
            Console.WriteLine("Aby zakończyć wpisz 'w' \n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--- Tryb licznika ---");
            Console.WriteLine("\n     ---> " + suma + " <---     \n");
            await PracaZLista.PokazListe(lista);
            await PracaZPlikiem.Wyswietl();

            MessageBox.Message();
        }
    }
}
