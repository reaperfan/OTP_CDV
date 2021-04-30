using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP_CDV
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
        void Run()
        {

            Console.WriteLine("Számlaszám:");
            string accnbr = Console.ReadLine();
            CDV_GEN cdv = new CDV_GEN();
            cdv.generateCDV(accnbr);

            Console.WriteLine("Round -> " + cdv.round);
            Console.WriteLine("SUM -> " + cdv.sum);
            Console.WriteLine("CDV IS---> " + cdv.cdv);

            Console.ReadKey();
        
        }
        public static int Round(int n)
        {
            int a = (n / 10) * 10;

            int b = a + 10;

            return b;
        }
    }
}
