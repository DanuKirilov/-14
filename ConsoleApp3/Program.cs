using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int n = Input("n=");
            Cicle(n);
            Console.WriteLine(n);
            Console.Read();
        }
        static void Cicle(int n)
        {
            int x = 1;
            while (x<=n)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
