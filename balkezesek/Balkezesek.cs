using System;

namespace balkezesek
{
    internal class Balkezesek
    {
        public string Nev { get; private set; }
        public string Elso { get; private set; }
        public string Utolso { get; private set; }
        public int Suly { get; private set; }
        public int Magassag { get; private set; }
        public Balkezesek(string sor)
        {
            string[] adat = sor.Split(';');
            Nev = adat[0];
            Elso = adat[1];
            Utolso = adat[2];
            Suly = Convert.ToInt32(adat[3]);
            Magassag = Convert.ToInt32(adat[4]);
        }
    }
}