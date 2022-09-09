using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number plz and I will repeat");
            int reply = (int.Parse(Console.ReadLine()));
            
            for(int i = 1; i < reply + 1; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
