using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatCounterTest
{
    public static class RepeatCounter
    {
        public static Dictionary<int, int> CountRepetitive(string input)
        {
            if (input == string.Empty)
                return null;

            //Converting input string to array of chars
            char[] chars = input.ToCharArray();
            
            //Initializing list for future numbers parsing
            List<int> numbers = new List<int>();
            
            //Temp number variable for parse output
            int number = 0;

            //Parsing chars array to int list
            foreach(var c in chars)
            {
                if(int.TryParse(c.ToString(), out number))
                {
                    numbers.Add(number);
                }
            }

            //If we have no numbers after parse we return 
            if (numbers.Count == 0)
                return null;

            //Temp return dictionary
            Dictionary<int, int> repetitivePairs = new Dictionary<int, int>();

            foreach(var n in numbers)
            {
                //Here we looking for specific key and if we have no such we create this key with value equal to 1
                if (!repetitivePairs.ContainsKey(n))
                {
                    repetitivePairs.Add(n, 1);
                }
                //Otherwise we just incrementing current value if we found existing key in the dictionary
                else
                {
                    repetitivePairs[n]++;
                }
            }

            return repetitivePairs;
        }
    }
}
