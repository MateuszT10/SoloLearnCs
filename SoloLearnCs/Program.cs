using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCs
{
    class Program
    {
        static void Ask(out string str) {
           str = Console.ReadLine();
        }
        static void Main(string[] args) {
            string str;
            Console.WriteLine("Zapytaj ");
            Ask(out str);
            Console.WriteLine("Zapytales o: " + str);
        }
    }            
}
