using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Method
{
    public static class Program
    {
        static void Main(string[] args)
        {
            sum(30);   // x=30 ; y=5 ; z=10
            sum(30, 1);  // x=30 ; y=1 ; z=10
            sum(30, 1, 2);  // x=30 ; y=1 ; z=2
            Console.ReadKey();
        }
        static void sum(int x, int y = 5, int z = 10)
        {
            Console.WriteLine(x + y + z);
        }
    }
}
