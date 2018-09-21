using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            int max=0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Írjon be még {0} számot!", + 10-i);
                tomb[i] = Convert.ToInt32(Console.ReadLine());
                if (tomb[i]>max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine("Legnagyobb szám: {0}", max);
            Console.ReadKey();
        }
    }
}
