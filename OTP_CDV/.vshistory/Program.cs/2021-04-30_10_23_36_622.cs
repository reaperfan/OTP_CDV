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

            foreach (var accpart in splitted)
            {
                for (int i = 0; i < accpart.Length; i++)
                {
                    try
                    {
                        sum += Convert.ToInt32(accpart) + Convert.ToInt32(mask[i]);
                    }
                    catch (Exception ex )
                    {
                        Console.WriteLine(ex.Message.ToString());
                        throw;
                    }
                    
                }
            }
            Console.WriteLine(sum);


        
        }
    }
}
