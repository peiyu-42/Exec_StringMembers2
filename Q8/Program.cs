using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{//隱藏手機的資訊，呈現 0935****46
    internal class Program
    {
        static void Main(string[] args)
        {
            //輸入手機號碼
            Console.Write("請輸入手機號碼:");
            string input = Console.ReadLine();

            //pre condition，input是不是空字串
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入手機號碼");
                return;
            }

            //若能解析成功，傳回true，number裡會有值；若解析失敗，傳回false，number =0
            bool isInt = int.TryParse(input, out int number);
            int length = input.Length;
            string start = input.Substring(0, 2);

            // pre condition，input是不是數字。是否有十個數字，開頭是否為09
            if (isInt == false || length != 10 || start!="09")
            {
                Console.WriteLine("請輸入正確的手機號碼");
                return;
            }

            //隱藏手機的資訊
            string phoneNumber = input.Substring(0, 4) + new string('*', 4) + input.Substring(8, 2);
            Console.WriteLine($"手機號碼: {phoneNumber}");

        }
    }
}
