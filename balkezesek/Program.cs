using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace balkezesek
{
    class Program
    {
        static List<Balkezesek> lista = new List<Balkezesek>();
        static int be = 0;
        static void Beolvas()
        {
            StreamReader sr = new StreamReader("balkezesek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Balkezesek(sr.ReadLine()));
            }
            sr.Close();
        }

        static void Harmadik()
        {
            Console.WriteLine("3.feladat: {0}",lista.Count());
        }

        static void Negyedik()
        {
            foreach (var l in lista)
            {
                if (l.Utolso.Contains("1999-10"))
                {
                    Console.WriteLine($"\t{l.Nev}, {l.Magassag*2.54}cm");
                }
            }
        }
        static void Otodik()
        {
            while (true)
            {
                Console.WriteLine("Írjon be egy évszámot 1990 és 1999 között!");
                be = Convert.ToInt32(Console.ReadLine());
                if (be >= 1990 && be <= 1999)
                {
                    Console.WriteLine("Jó számot adott meg.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás adat,kérek egy 1990 és 1999 közötti évszámot.");
                }
            }
        }
        static void Hatodik()
        {
            foreach (var i in lista)
            {

            }
        }

        static void Main(string[] args)
        {
            //var b = new Balkezesek("Jim Abbott","1989-04-08","1999-07-21",200,75);
            Beolvas();
            Harmadik();
            Console.WriteLine("4.feladat:");
            Negyedik();
            Console.WriteLine("5.feladat:");
            Otodik();
            Console.WriteLine("6.feladat:");
            Hatodik();
            Console.ReadLine();
        }
    }
}
