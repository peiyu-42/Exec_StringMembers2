using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{//將字串 "Allen Kuo" 轉成大寫 "ALLEN KUO"
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Allen Kuo";
            Console.WriteLine(name);

            //轉換成大寫
            string nameB = name.ToUpper();
            Console.WriteLine(nameB);
        }
    }
}
