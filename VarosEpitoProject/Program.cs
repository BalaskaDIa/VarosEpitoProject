using System;
using System.Collections.Generic;
using System.IO;
using VarosEpitoProject;

namespace VarosEpitoProject
{
    class Program
    {
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
    }
    }
}
    

                    

                
            
    
    
                


                
            
            
    

                    

