using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Podaj wiek: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twoj wiek to {0}", age);
        }
    }
}
