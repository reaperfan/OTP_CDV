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
        }
        void Run()
        {
            string mask = "97319731-9731973";
            Console.Write("->Számlaszám:");
            string accnbr = Console.ReadLine();
            string[] splitted = accnbr.Split('-');

            foreach (var item in accnbr)
            {
                if (item != '-')
                {

                }
            }


        
        }
    }
}
