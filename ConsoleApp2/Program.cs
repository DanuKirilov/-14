using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //static void Func()
        //{
            //int x = 1;
            //do
            //{
            //    Console.WriteLine(x); x = 1;
            //}
            //while (x <= 10);
            //for(int x=1;x<=10;x++)
            //{
            //    Console.WriteLine(x);
            //}
        //}
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }
        static void Func()
        {
            for (int x = 10; x >= 1; x--)
            {
                Console.WriteLine(x);
            }
        }
    }
}
