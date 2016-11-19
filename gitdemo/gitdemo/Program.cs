using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gitdemo
{
    class Program
    {
        static void Main(string[] args)
        {

            TierCalculator myTierCalc = new TierCalculator(1000000, 0.0025);
            Console.WriteLine(myTierCalc.getAccrual());
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
