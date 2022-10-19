using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{//比對使用者輸入值是否為 "Allen", 區分大小寫
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Allen";
            Console.Write($"請輸入{name}，請注意大小寫:");
            string input = Console.ReadLine();

            //pre condition
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"您沒有輸入");
                return;
            }

            if (name == input) 
            {
                Console.WriteLine("輸入正確");
            }
            else
            {
                Console.WriteLine("輸入錯誤，請注意大小寫");
            }

        }
    }
}
