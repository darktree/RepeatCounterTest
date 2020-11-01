using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatCounterTest
{
    class Program
    {
        public static string input;

        static void Main(string[] args)
        {
            Console.WriteLine("Type a string with numbers here");
            input = Console.ReadLine();

            if(RepeatCounter.CountRepetitive(input) != null)
            {
                foreach(var pair in RepeatCounter.CountRepetitive(input))
                {
                    Console.WriteLine(pair);
                }

                Console.ReadLine();
            }
        }
    }
}
