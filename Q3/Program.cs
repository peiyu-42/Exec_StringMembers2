using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{//將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "aLLeN kUO";
            Console.WriteLine(name);

            //轉換成 "Allen Kuo"
            string firstNameOne = name.Substring(0, 1);
            string firstName = name.Substring(1,4);
            string lastNameOne = name.Substring(6, 1);
            string lastName = name.Substring(7, 2);
            string raw = firstNameOne.ToUpper() + firstName.ToLower() + " " + lastNameOne.ToUpper() + lastName.ToLower();
            Console.WriteLine(raw);
        }
    }
}
