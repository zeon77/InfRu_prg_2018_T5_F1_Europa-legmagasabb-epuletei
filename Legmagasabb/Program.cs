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

            //6. feladat:
            Console.WriteLine($"6.feladat: {(épületek.Any(x => x.Ország == "Olaszország") ? "Van" : "Nincs")} olasz épület az adatok között!");

            //7. feladat:
            const double MetersToFeet = 3.280839895;
            Console.WriteLine($"7.feladat: 666 lábnál magasabb épületek száma: {épületek.Where(x => x.Magasság * MetersToFeet > 666).Count()}");

            //8. feladat:
            Console.WriteLine($"8.feladat: Ország statisztika");
            épületek
                .GroupBy(x => x.Ország)
                .Select(gr => new { Ország = gr.Key, Darab = gr.Count() })
                .OrderBy(x => x.Ország)
                .ToList().ForEach(x => Console.WriteLine($"\t{x.Ország} - {x.Darab} db"));

            //9. feladat:
            Console.WriteLine($"9.feladat: nemet.txt");
            using (StreamWriter sw = new StreamWriter("nemet.txt"))
            {
                //Az egyedi (distinct) német városokat kell megkeresni, és a féjlba beleírni:
                épületek
                    .Where(x => x.Ország == "Németország")
                    .GroupBy(x => x.Város)
                    .Select(g => g.First())
                    .ToList().ForEach(x => sw.WriteLine($"{x.Város}"));
            }
        }
    }
}
