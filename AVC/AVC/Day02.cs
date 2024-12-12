using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AVC
{
    internal class Day02
    {
        public static void Program()
        {
            #region Members
            List<string> data = new List<string>(File.ReadAllLines("C:\\Users\\ellio\\Documents\\Repos\\AVC\\day02.txt"));
            List<int> currentRow = new List<int>();
            int safe = new int();
            #endregion

            //Getting the file Columns into different lists
            foreach (string line in data)
            {
                string direction = "none";
                bool okay = true;

                currentRow = line.Split(' ')
                    .Where(s => int.TryParse(s, out _))
                    .Select(s => int.Parse(s))
                    .ToList();

                if (currentRow[0] == currentRow[1])
                {
                    continue;
                }
                else if (currentRow[0] < currentRow[1])
                {
                    direction = "up";
                }
                else
                {
                    direction = "down";
                }

                for (int i = 0; i < currentRow.Count - 1; i++)
                {
                    if (direction == "up" && (!(currentRow[i+1] > (currentRow[i] + 3)) && !(currentRow[i + 1] <= currentRow[i])))
                    {
                        continue;
                    }
                    else if (direction == "down" && (!(currentRow[i + 1] < (currentRow[i] - 3)) && !(currentRow[i + 1] >= currentRow[i])))
                    {
                        continue;
                    }
                    else
                    {
                        okay = false;
                    }
                }
                if (okay)
                {
                    safe += 1;
                }
            }
            Console.WriteLine("Day Two Results:");
            Console.WriteLine(safe);
        }
    }
}
