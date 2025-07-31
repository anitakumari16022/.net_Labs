using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] trascations = { 200, -150, 340, 500, -100 };
            int sum = 0;
            for (int i = 0; i < trascations.Length; i++)
            {
              
                sum += trascations[i];
                
            }
            Console.WriteLine(sum);
        }
    }
}
