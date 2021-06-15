using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productOfTwoVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneNum = int.Parse(Console.ReadLine());
            int twoNum = int.Parse(Console.ReadLine());

            Console.WriteLine(oneNum * twoNum);
            Console.ReadKey();
        }
    }
}