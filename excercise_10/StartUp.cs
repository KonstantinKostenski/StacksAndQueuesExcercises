using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_10
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());
            int days = 0;
            List<int> indexes = new List<int>();
            List<int> plantsArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                for (int i = 0; i < plantsArray.Count - 1; i++)
                {
                    if (plantsArray[i] < plantsArray[i + 1])
                    {
                        indexes.Add(i + 1);
                    }
                }
                if (indexes.Count == 0)
                {
                    break;
                }
                for (int i = indexes.Count - 1; i >= 0 ; i--)
                {
                    plantsArray.RemoveAt(indexes[i]);
                }
                days++;
                indexes.Clear();
            }
            Console.WriteLine(days);
            
        }
    }
}
