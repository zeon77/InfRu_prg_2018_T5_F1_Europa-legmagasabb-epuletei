using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Legmagasabb
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Épület> épületek = new List<Épület>();
            foreach (var sor in File.ReadAllLines("legmagasabb.txt").Skip(1))
                épületek.Add(new Épület(sor));

            //3.
            Console.WriteLine($"3. feladat: Épületek száma: {épületek.Count} db");

            //4. feladat:
            Console.WriteLine($"4. feladat: Emeletek összege: {épületek.Sum(x => x.Emelet)}");

            //5.
            double maxMagasság = épületek.Max(y => y.Magasság);
            var LegmagasabbÉpület = épületek.Single(x => x.Magasság == maxMagasság);
            Console.WriteLine($"5.feladat: A legmagasabb épület adatai:");
            Console.WriteLine($"\t Név: {LegmagasabbÉpület.Név}");
            Console.WriteLine($"\t Város: {LegmagasabbÉpület.Város}");
            Console.WriteLine($"\t Ország: {LegmagasabbÉpület.Ország}");
            Console.WriteLine($"\t Magasság: {LegmagasabbÉpület.Magasság}");
            Console.WriteLine($"\t Emelet: {LegmagasabbÉpület.Emelet}");
            Console.WriteLine($"\t Építés éve: {LegmagasabbÉpület.ÉpítésÉve}");
        }
    }
}
