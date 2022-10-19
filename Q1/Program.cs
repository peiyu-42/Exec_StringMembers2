using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{//將" abc " 左右的空白刪除
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = " abc ";
            Console.WriteLine($"原先:{value}。");

            //除去左右側的空白
            string newValue = value.Trim();
            Console.WriteLine($"結果:{newValue}。");

        }
    }
}
