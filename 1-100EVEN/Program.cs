using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100EVEN
{
    class Program
    {
        static void Main(string[] args)
        {
            //for odd for (int i = 1; i <= 100; i+=2)

            for (int i = 2; i <= 100; i+=2)
                Console.Write("{0,8}", i.ToString("D"));
            Console.WriteLine("");
            const int NUM_DASHES = 40;
            for (int x = 0; x < NUM_DASHES; ++x)
            Console.ReadLine();
            
        }
    }
}

