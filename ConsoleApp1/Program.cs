using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Func()
        {
            int x = 1;
            while (x <= 10) 
            {
                Console.WriteLine(x);
                x = x + 1;//x+=1;x++
            }
        }
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }
    }
}
