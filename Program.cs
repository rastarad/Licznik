using Licznik;
using System;
using System.Collections.Generic;

ConsoleKeyInfo liczba = new ConsoleKeyInfo();
int suma = 0;
List<string> lista = new List<string>();
do
{
    await Konfiguracja.Konfigurowanie(suma, lista);

    liczba = Console.ReadKey(true);

    if (liczba.Key == ConsoleKey.D)
    {
        Console.Clear();
        suma++;
    }
    else if (liczba.Key == ConsoleKey.O)
    {
        Console.Clear();
        suma--;
    }
    else if (liczba.Key == ConsoleKey.R)
    {
        Console.Clear();
        suma = 0;
    }
    else if(liczba.Key == ConsoleKey.Z)
    {
        Console.Clear();
        lista.Add(suma.ToString());
    }
    else if (liczba.Key == ConsoleKey.X)
    {
        Console.Clear();
        if (lista.Any())
        {
            lista.RemoveAt(lista.Count - 1);
        }
    }
    else if (liczba.Key == ConsoleKey.U)
    {
        Console.Clear();
        lista.Clear();
    }
    else if(liczba.Key == ConsoleKey.S)
    {
        Console.Clear();
        Console.WriteLine("\n--- Tryb zapisu ---");
        await Zapis.Zapisz(lista, liczba);
    }
    else if (liczba.Key == ConsoleKey.L)
    {
        Console.Clear();
        Console.WriteLine("\n--- Tryb odczytu ---");
        await Odczyt.Wczytaj(lista, liczba);
    }
    else if (liczba.Key == ConsoleKey.Delete)
    {
        Console.Clear();
        Console.WriteLine("\n--- Tryb czyszczenia ---");
        await Wyzerowanie.Zeruj(lista,liczba);
    }
    else 
    {
        Console.Clear();
    }

} while (!(liczba.Key == ConsoleKey.W));

