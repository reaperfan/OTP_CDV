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
            string mask = "97319731";
            Console.Write("->Számlaszám:");
            string accnbr = Console.ReadLine();
            string[] splitted = accnbr.Split('-');

            int sum = 0;
            int round = 0;
            int cdv = 0;

            foreach (var accpart in splitted)
            {
                for (int i = 0; i < accpart.Length; i++)
                {
                    try
                    {

                        sum += Int32.Parse(accpart[i].ToString()) * Int32.Parse(mask[i].ToString());
                                                

                    }
                    catch (Exception ex )
                    {
                        Console.WriteLine(ex.Message.ToString());
                        throw;
                    }
                    
                }
            }
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

            return b
        }
    }
}
