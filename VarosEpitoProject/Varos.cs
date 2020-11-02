using System;
using System.Collections.Generic;
using System.Text;

namespace VarosEpitoProject
{
    class Varos
    {
        string nev;
        int lakosok;
        int hazak;
        int uzletek;

        public Varos(string nev, int meret)
        {

            this.nev = nev;
            if (meret == 1)
            {
                this.hazak = 150; this.uzletek = 20;
            }
            else if (meret == 2)
            {
                this.hazak = 300; this.uzletek = 45;
            }
            else if (meret == 3)
            {

                this.hazak = 450; this.uzletek = 50;
            }
            this.lakosok = this.MaxLakosok / 2;

        }

        public string Nev
        {
            get
            {
                return this.nev;
            }
        }
        public int Lakosok
        {
            get
            {
                return this.lakosok;
            }
            set
            {
                if (this.lakosok > value)
                {
                    Console.WriteLine("A lakosok száma nem csökkenhet!");
                }
                else if (this.Lakosok > this.MaxLakosok)
                {
                    Console.WriteLine("A lakosok száma nem lépheti át a maximumot!");
                }
                else
                {
                    this.lakosok = value;
                }
            }
        }

        public int Hazak
        {
            get
            {
                return this.hazak;
            }
            set
            {
                if (this.MaxLakosok < this.lakosok)
                {
                    Console.WriteLine("Nem lépheti át");
                }
                else
                {
                    this.hazak = value;
                }
            }
        }
        public int Uzletek
        {
            get
            {
                return this.uzletek;
            }
        }
        public int MaxLakosok
        {
            get
            {
                return this.hazak * 6;
            }
        }
        public double Alapterulet
        {
            get
            {
                return this.hazak * 110 + this.uzletek * 85.5;
            }
        }
        public override string ToString()
        {
            return String.Format
                ("{0} - Lakosok: {1}/{2} - Üzletek: {3} - Alapterület: {4}m2",
                this.nev, this.lakosok, this.uzletek, this.Alapterulet
                );
        }
    }
}
