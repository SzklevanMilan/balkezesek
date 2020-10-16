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
                    Console.WriteLine($"\t{l.Nev}, {Math.Round(l.Magassag*2.54),1:N1}cm");
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
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás adat! Kérek egy 1990 és 1999 közötti számot.");
                }
            }
        }
        static void Hatodik()
        {
            double suly = 0;
            double  db = 0;
            foreach (var i in lista)
            {
                if (be>=int.Parse(i.Elso.Substring(0,4)) && be<= int.Parse(i.Utolso.Substring(0, 4))) 
                {
                    suly = suly + i.Suly;
                    db++;
                }
            }
            double atlag = Math.Round(suly / db,2);
            Console.WriteLine($"6.feladat: {atlag} font");
        }
        static void Bonusz()
        {
            var nevek = from l in lista
                        select l.Nev;
            var nevLista = nevek.ToList();
            var kezdoBetu = from b in nevLista
                            orderby b
                            where b[0] != 'R'
                            group b by b[0] into tempNevek
                            select tempNevek;
            foreach (var csoport in kezdoBetu)
            {
                Console.WriteLine("kezdőbetű: {0} ",csoport.Key);
                foreach (var tag in csoport)
                {
                    Console.WriteLine($"\t{tag}");
                }
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
            Hatodik();
            Bonusz();
            Console.ReadLine();
        }
    }
}
