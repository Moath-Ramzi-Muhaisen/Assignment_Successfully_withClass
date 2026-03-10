using System;
using System.Collections.Generic;
using System.Text;

namespace Assaiment_successfully_withClass.Classes
{
    internal class Class1
    {
        public void printResult(string input) 
        {
            string str = input;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic[c] = 1;
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($" {item.Key} :  {item.Value} ");
            }
        }
    }

}
