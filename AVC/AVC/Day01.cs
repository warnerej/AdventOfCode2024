using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVC
{
    internal class Day01
    {
        public static void Program()
        {

            #region Members
            List<string> data = new List<string>(File.ReadAllLines("C:\\Users\\ellio\\Documents\\Repos\\AVC\\day02.txt"));
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int difference = new int();
            int similarityScore = new int();
            #endregion

            //Getting the file Columns into different lists
            foreach (string line in data)
            {
                if (int.TryParse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0], out int number))
                {
                    list1.Add(number);
                }
                if (int.TryParse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1], out int number2))
                {
                    list2.Add(number2);
                }

            }

            list1.Sort();
            list2.Sort();

            #region Part One
            for (int i = 0; i < list1.Count; i++)
            {
                difference += Math.Abs(list1[i] - list2[i]);
            }
            #endregion

            #region Part Two
            for (int i = 0; i < list1.Count; i++)
            {
                for (int k = 0; k < list2.Count; k++)

                    if (list1[i] == list2[k])
                    {
                        similarityScore += list1[i];
                    }
            }
            #endregion

            Console.WriteLine("Day One Results:");
            Console.WriteLine(difference);
            Console.WriteLine(similarityScore);
        }
    }
}
