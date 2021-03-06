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
            int roundup = 0;

            foreach (var accpart in splitted)
            {
                for (int i = 0; i < accpart.Length; i++)
                {
                    try
                    {

                        sum += Int32.Parse(accpart[i].ToString()) * Int32.Parse(mask[i].ToString());
                        roundup = Round(sum);                    }
                    catch (Exception ex )
                    {
                        Console.WriteLine(ex.Message.ToString());
                        throw;
                    }
                    
                }
            }
            Console.WriteLine(sum);

            Console.ReadKey();
        
        }
        public static int Round(int n)
        {
            // Smaller multiple 
            int a = (n / 10) * 10;

            // Larger multiple 
            int b = a + 10;

            // Return of closest of two 
            return (n - a > b - n) ? b : a;
        }
    }
}
