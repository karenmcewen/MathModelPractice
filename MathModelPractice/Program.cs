using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModelPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a practice space for using c# to perform mathematical operations

            //ADDITION of INTEGERS using an input array
            int[] addNums = new int[3];//array has a set length
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter a number");
                addNums[i] = int.Parse(Console.ReadLine());
                sum = sum + addNums[i];
            }
            Console.WriteLine("total = {0}", sum);
                      
            
        }
    }
}
