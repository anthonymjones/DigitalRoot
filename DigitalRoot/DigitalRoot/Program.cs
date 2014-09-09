using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            DigitalRoot("31337");
            DigitalRoot("45734");

            Console.ReadKey();
        }
        static void DigitalRoot(string rootThis)
        {
            List<string> rootNumList = (rootThis).Split().ToList();
            int finalRoot;
            //while the sum is greater than 9
            while (finalRoot > 9)
            {
                //continue to add each number together
                

            }
            //if the number is <= 9, print the number
            Console.WriteLine(finalRoot);
            
        }
    }
}
