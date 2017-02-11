using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCs
{
    class Program
    {
        static void sqr(ref int x) {
           x= x*x;
        }
        static void Main(string[] args) {
            int a = 3;
            sqr(ref a);
            Console.WriteLine(a);
        }
    }            
}
