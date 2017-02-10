using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCs
{
    class Program
    {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("x ");
                string str = Console.ReadLine();
                if (str == "exit") break;
                int x = Convert.ToInt32(str);
                Console.WriteLine("y ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x+y= {0}", x+y);
            }
        }
    }            
}
