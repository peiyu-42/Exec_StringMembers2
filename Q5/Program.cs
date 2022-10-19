using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{//比對使用者輸入值是否為 "Allen" 不拘大小寫
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Allen";
            Console.Write($"請輸入{name}，不拘大小寫:");
            string input = Console.ReadLine();

            //pre condition
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"您沒有輸入");
                return;
            }

            //全部轉成小寫
            string nameLower = name.ToLower();
            string inputLower = input.ToLower();

            //判斷是否輸入正確
            if (nameLower == inputLower)
            {
                Console.WriteLine("輸入正確");
            }
            else
            {
                Console.WriteLine("輸入錯誤");
            }

        }
    }
}
