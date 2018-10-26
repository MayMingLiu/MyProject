using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "1+2+3+4";
            string str = Console.ReadLine();
            string[] strNumbers = str.Split('+');
            int iNumberSum = 0;


            foreach (string number in strNumbers)
            {
                iNumberSum += Int32.Parse(number);
            }

            Console.Write(iNumberSum);
            Console.ReadLine();

        }
    }
}
