using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please Enter your number to print table ");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=10)
            {
                
                Console.WriteLine(i + " X " + num + " = " + num * i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
