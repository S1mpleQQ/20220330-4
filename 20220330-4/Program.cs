using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220330_4
{
    class Program
    {
        private static int fac(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * fac(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("20!={0}", fac(20));
            Console.ReadLine();
        }
    }
}
