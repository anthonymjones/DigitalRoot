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

            int rootSum = 0;
            for (int i = 0; i < rootThis.Length; i++)
            {
                rootSum += int.Parse(rootThis[i].ToString());
                
            }
            int input = rootSum.ToString().Sum(x => int.Parse(x.ToString()));

            Console.WriteLine(input);

          
        }
    }
}
