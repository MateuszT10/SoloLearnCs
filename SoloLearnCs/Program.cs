using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCs
{
    class Program
    {
        public string Imie{ get; set; }
        public string Nazwisko { get; set; }
        private int wiek;
        static void Main(string[] args) {
            Program p = new Program();
            p.Imie = "Mateusz";
            p.Nazwisko = "Trompka";
            Console.WriteLine(p.Imie);
            Console.WriteLine(p.Nazwisko);
        }
    }            
}
