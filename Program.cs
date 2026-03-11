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

            Console.WriteLine($"2. feladat:");
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
        }
    }
}