using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_6
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            Queue<long[]> petrolPumps = new Queue<long[]>();
            long index = 0;
            
            for (long i = 0; i < N; i++)
            {
                petrolPumps.Enqueue(Console.ReadLine().Split().Select(long.Parse).ToArray());
            }

            while (true)
            {
                long fuelLeft = 0;
                foreach (long[]pump in petrolPumps)
                {
                    long fuel = pump[0];
                    long distance = pump[1];

                    fuelLeft += fuel - distance;

                    if (fuelLeft < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }

                }

                if (fuelLeft >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
