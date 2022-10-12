using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Kémia
{
    class Program
    {
        static List<felfedezesek> kemia = new List<felfedezesek>();

        public static void adatokBeolvasasa(string adatFile)
        {
            if (!File.Exists(adatFile))
            {
                Console.WriteLine("A forrásadatok hiányoznak");
                Console.WriteLine();
                Environment.Exit(0);
            }
            using (StreamReader sr = new StreamReader(adatFile))
            {
                while (!sr.EndOfStream)
                {
                    kemia.Add(new felfedezesek(sr.ReadLine()));
                }

            }
        }
        public static void Kemiai_Elemek_Szama()
        {
            Console.WriteLine($"3. feladat: Elemek száma: {kemia.Count - 1}");
        }
        public static void okor()
        {
            Console.WriteLine($"4. feladat: felfedezések száma az Ókórban: {kemia.Count(x => x.Ev == "Ókor")}");
        }
        public static string vegyjel_bekeres()
        {
            Console.Write("5. feladat:Adjon meg egy vegyjelet:");
            string beker;
            while (!Regex.IsMatch(beker = Console.ReadLine(), @"^[a-zA-Z]+$"))
            {
                Console.Write("5. feladat:Adjon meg egy vegyjelet:");
                Console.ReadLine();
            }
            return beker;
        }
        public static void kereses(string beker)
        {
            Console.WriteLine("6. feladat: Keresés");
            bool vanevegyjel = false;
            for (int i = 0; i < kemia.Count; i++)
            {

                if (kemia[i].Vegyjel.ToUpper()
                    == beker.ToUpper())
                {
                    vanevegyjel = true;
                    Console.WriteLine($"\tAz elem vegyjele:{kemia[i].Vegyjel}");
                    Console.WriteLine($"\tAz elem neve:{kemia[i].Nev}");
                    Console.WriteLine($"\tRendszáma:{kemia[i].Rendszam}");
                    Console.WriteLine($"\tFelfedezés éve:{kemia[i].Ev}");
                    Console.WriteLine($"\tFelfedező:{kemia[i].Felfedezo}");
                }
            }
            if (vanevegyjel == false)
            {
                Console.WriteLine("Nincs ilyen elem az adatbázisban!");
            }

        }
      
        static void Main(string[] args)
        {
            adatokBeolvasasa(@"C:\Users\cisco\source\repos\Kémia\Kémia\felfedezesek.csv");
            //3. feladat
            Kemiai_Elemek_Szama();
           //4. feladat
            okor();
            //5.feladat
            string vegyjel = vegyjel_bekeres();
            //6.feladat
            kereses(vegyjel);
            Console.ReadKey();
        }
       
    }
}
