using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{//假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateString = "1100225";

            // 分別取出年月日
            string year = dateString.Substring(0, 3);
            string month = dateString.Substring(3, 2);
            string day = dateString.Substring(5, 2);

            // 字串轉換成時間
            DateTime date = new DateTime(Convert.ToInt32(year)+1911, Convert.ToInt32(month), Convert.ToInt32(day));
            Console.WriteLine($"日期: {date:yyyy/MM/dd}");

        }
    }
}
