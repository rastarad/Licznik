using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Licznik
{
    internal class PracaZPlikiem
    {

        public static async Task Dodaj(List<string> lista)
        {
            using StreamWriter plik = new StreamWriter(@"C:\Users\48516\Desktop\lista.txt", append: true);
            lista.ForEach(n => plik.WriteAsync(n + " "));
            MessageBox.DodajMessage("!!! Lista została dodana do pliku !!!");
        }
        public static async Task Usun()
        {
            using StreamWriter plik = new StreamWriter(@"C:\Users\48516\Desktop\lista.txt");
            await plik.WriteAsync("");
            MessageBox.DodajMessage("!!! Plik został wyzerowany !!!");
        }
        public static async Task Zaladuj(List<string> lista3)
        {
            Console.WriteLine("\n--- Bieżący plik: ---");
            string[] tablicaJ = File.ReadAllLines(@"C:\Users\48516\Desktop\lista.txt");
            string[] tablicaW = tablicaJ[0].Split(" ");
            for(int i = 0; i < tablicaW.Length; i++)
            {
                lista3.Add(tablicaW[i]);
                Console.Write(tablicaW[i] + " ");
            }
            MessageBox.DodajMessage("!!! Plik został załadowany do listy pomocniczej !!!");
        }
        public static async Task Wyswietl()
        {
            Console.WriteLine("\n--- Bieżący plik: ---");
            string[] lista2 = File.ReadAllLines(@"C:\Users\48516\Desktop\lista.txt");
            for (int i = 0; i < lista2.Length; i++)
            {
                Console.WriteLine(lista2[i] + " ");
            }
        }
    }
}
