using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        class Zeneszam
        {
            string cim;
            string szerzo;
            int hossz;

            public string Cim
            {
                get { return cim; }
            }
            public string Szerzo
            {
                get { return szerzo; }
            }
            public int Hossz
            {
                get { return hossz; }
                set
                {
                    if (value > 0) hossz = value;
                }
            }
            public Zeneszam(string cim, string szerzo, int hossz)
            {
                this.cim = cim;
                this.szerzo = szerzo;
                this.hossz = hossz;
            }
            public static void Feldolgozas(string input)
            {
                string[] temp = input.Split(';');
                new Zeneszam(temp[0], temp[1], int.Parse(temp[2]));
            }
            public string FormazottIdo()
            {
                return ($" {hossz / 60}:{hossz % 60}");
            }
        }
        class Album
        {

        }
        static void Main(string[] args)
        {

        }
    }
}
