using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InformatikaiRendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("kolcsonzes.txt");
            int[] adatok = new int[sorok.Length];
            for (int i = 0; i < sorok.Length; i++)
            {
                adatok[i] = int.Parse(sorok[i].Trim());
            }

            Console.WriteLine("2. feladat:");
            Console.WriteLine($"A fajlban {adatok.Length} meresi adat talalhato.");

            int hibak = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] == -1)
                    hibak++;
            }

            Console.WriteLine();
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"Meresi hibak szama: {hibak}");

            string[] idok = {
                "9:00-9:10", "9:10-9:20", "9:20-9:30", "9:30-9:40",
                "9:40-9:50", "9:50-10:00", "10:00-10:10", "10:10-10:20",
                "10:20-10:30", "10:30-10:40", "10:40-10:50", "10:50-11:00"
            };

            int maxErtek = -1;
            int maxIndex = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] != -1 && adatok[i] > maxErtek)
                {
                    maxErtek = adatok[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("4. feladat:");
            Console.WriteLine($"Legtobb kolcsonzes: {idok[maxIndex]} ({maxErtek} konyv)");

            int osszesen = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] != -1)
                    osszesen += adatok[i];
            }

            Console.WriteLine();
            Console.WriteLine("5. feladat:");
            Console.WriteLine($"Osszes kolcsonzott konyv: {osszesen}");
        }
    }
}