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

            Console.WriteLine("Beolvasas kesz.");
        }
    }
}
