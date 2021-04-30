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
            Console.ReadLine("Számlaszám:");
            CDV_GEN cdv = new CDV_GEN()
            Console.WriteLine("Round -> " + round);
            round = Round(sum);
            cdv = Math.Abs(round - sum);
            Console.WriteLine(sum);
            Console.WriteLine(round);
            Console.WriteLine("CDV IS---> " + cdv);

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
