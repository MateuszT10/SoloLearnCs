using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCs
{
    class Program
    {
        static int power(int x, int y=2) {
            int result = 1;
            for (int i = 0; i<y; i++) {
                result *= x;
            }
            return result;
        }
        static void Main(string[] args) {
            Console.WriteLine(power(5,3));
        }
    }            
}
