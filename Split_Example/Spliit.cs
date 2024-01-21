using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Example
{
    internal class Spliit
    {
        public void splitW(string input,char c)
        {
            String[] output = input.Split(c);
            foreach (string s in output)
            {
                Console.WriteLine(s);
            }
        }
    }
}
