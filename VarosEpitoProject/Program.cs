using System;
using System.Collections.Generic;
using System.IO;
using VarosEpitoProject;

namespace VarosEpitoProject
{
    class Program
    {
        private static Varos felhasznalo;
        static void Main(string[] args)
        {
            List<Varos> varosok = new List<Varos>();

            varosok.Add(new Varos("Budapest", 3));
            varosok.Add(new Varos("Washington", 1));
            varosok.Add(new Varos("London", 2));

            try
            {
                using (var sr = new StreamReader("varosok.csv"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    string[] st = sr.ReadLine().Split(';');
                    varosok.Add(new Varos(st[0], Convert.ToInt32(st[1])));

                }
                varosok.Sort((x, y) => x.Alapterulet.CompareTo(y.Alapterulet));
            }
            catch (IOException e)
            {
                Console.WriteLine("A fájl nem olvasható!");
                Console.WriteLine(e.Message);
            }
        }
            public static void SajatVaros()
            {

                Console.WriteLine("Adja meg a városa nevét!");
                string nev = Console.ReadLine();
                int meret = 0;
                do
                {
                    Console.WriteLine("Adja meg a városa méretét!");
                    meret = Convert.ToInt32(Console.ReadLine());
                    if (meret != 1 && meret != 2 && meret != 3)
                    {
                        Console.WriteLine("Rossz értéket adott meg!");
                    }
                } while (meret != 1 && meret != 2 && meret != 3);

                felhasznalo = new Varos(nev, meret);

            }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Válasszon egy menüpontot!");
            Console.WriteLine("a.) Lakásokat betelepíteni");
            Console.WriteLine("b.) Házat építeni");
            Console.WriteLine("c.) Üzletet építeni");
            Console.WriteLine("d.) Kilépni");
            Console.Write("\r\nVálasztott opció: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Lakosok száma");
                    felhasznalo.Lakosok = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    Random r = new Random();
                    felhasznalo.Hazak += r.Next(10, 20);
                    break;
                case "3":
                    felhasznalo.UzletetEpit(10);
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
    
}
    

                    

                
            
    
    
                


                
            
            
    

                    

