using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GitConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            int max = 0;
            int min = 0;
            int db = 10;
            bool asd = false;
            Console.WriteLine("Hány darab számot szeretne beírni?");

            try
            {
                db = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nem szám lett megadva!");
                Thread.Sleep(2000);
                return;
            }



            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Írjon be még {0} számot!", +db - i);
                try
                {
                    tomb[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Nem szám lett megadva!");
                    Thread.Sleep(2000);
                    return;
                }


                if (asd == false)
                {
                    min = tomb[i];
                    max = tomb[i];
                    asd = true;
                }
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine("Legnagyobb szám: {0}\nLegkisebb szám: {1}", max, min);
            Console.ReadKey();
        }
    }
}
