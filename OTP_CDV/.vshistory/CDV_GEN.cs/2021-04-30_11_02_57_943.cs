using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP_CDV
{
    public class CDV_GEN
    {
        public int sum  { get; set; }
        public int round { get; set; }
        public int cdv { get; set; }
        public bool generateCDV(string accnbr)
        {
            string mask = "97319731";
            Console.Write("->Számlaszám:");
            string[] splitted = accnbr.Split('-');
            if (String.IsNullOrEmpty(accnbr.Trim()))
            {
                Console.WriteLine("Bad Input");
                return false;
            }
            foreach (var accpart in splitted)
            {
                for (int i = 0; i < accpart.Length; i++)
                {
                    try
                    {
                        sum += Int32.Parse(accpart[i].ToString()) * Int32.Parse(mask[i].ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                        throw;
                    }
                }
            }
            round = Round(sum);
            cdv = Math.Abs(round - sum);
            if (cdv % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int Round(int n)
        {
            int a = (n / 10) * 10;

            int b = a + 10;

            return b;
        }
    }
}
