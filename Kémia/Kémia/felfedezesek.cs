using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace Kémia
{
    class felfedezesek
    {
        public felfedezesek(string sor)
        {
            string[] sorelemek = sor.Split(';');
            this.Ev = sorelemek[0];
            this.Nev = sorelemek[1];
            this.Vegyjel = sorelemek[2];
            this.Rendszam = sorelemek[3];
            this.Felfedezo = sorelemek[4];
        }
        public string Ev { get; set; }
        public string Nev { get; set; }
        public string Vegyjel { get; set; }
        public string Rendszam { get; set; }
        public string Felfedezo { get; set; }
    }
}
