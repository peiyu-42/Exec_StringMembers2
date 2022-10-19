using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{//計算兩數之和,並只呈現小數二位數
    internal class Program
    {
        static void Main(string[] args)
        {
            //輸入兩個數字
            Console.Write("請輸入數字A:");
            string inputA = Console.ReadLine();
            Console.Write("請輸入數字B:");
            string inputB = Console.ReadLine();

            //pre condition，input是不是空字串
            if (string.IsNullOrEmpty(inputA) || string.IsNullOrEmpty(inputA))
            {
                Console.WriteLine($"您沒有輸入數字");
                return;
            }

            //若能解析成功，傳回true，numberA和numberB裡會有值；若解析失敗，傳回false，numberA 或 numberB =0
            bool isdoubleA = double.TryParse(inputA, out double numberA);
            bool isdoubleB = double.TryParse(inputB, out double numberB);

            // pre condition，input是不是數字
            if (isdoubleA == false || isdoubleB == false)            
            {
                Console.WriteLine("您必須輸入數字");
                return;
            }

            //計算兩個數的總和
            double sum = numberA + numberB;

            //只呈現小數二位數
            string raw = sum.ToString("0.00");
            Console.WriteLine($"兩數之和為 {raw}");

        }
    }
}
