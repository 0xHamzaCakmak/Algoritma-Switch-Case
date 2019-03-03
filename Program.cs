using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155.gün_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yılın 5. Günü salı ise 155. gün hangisidir...?
            int k = 155 % 7;
            switch(k)
            {
                case 0: Console.WriteLine("Perşembe"); break;
                case 1: Console.WriteLine("cuma"); break;
                case 2: Console.WriteLine("Cumartesi"); break;
                case 3: Console.WriteLine("pazar"); break;
                case 4: Console.WriteLine("pazartesi"); break;
                case 5: Console.WriteLine("salı"); break;
                case 6: Console.WriteLine("Çarşamba"); break;
            }
        }
    }
}
