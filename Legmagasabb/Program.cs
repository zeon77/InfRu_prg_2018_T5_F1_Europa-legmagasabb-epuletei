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

        }
    }
}
