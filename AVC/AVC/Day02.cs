using System;
using System.Collections;
using System.Collections.Generic;
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
            List<string> data = new List<string>(File.ReadAllLines("C:\\Users\\ellio\\Documents\\Repos\\AVC\\day01.txt"));
            List<int> currentRow = new List<int>();
            int unSafe = new int();
            #endregion

            //Getting the file Columns into different lists
            foreach (string line in data)
            {
                line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var parts in line)
                {
                    if(int.TryParse(line, out int number))
                    {
                        currentRow.Add(number);
                    }
                }

                //This needs to be redone!!!
                for (int i = 0; i < currentRow.Count; i++)
                {
                    if (currentRow[1] != currentRow.Count - 1)
                    {

                    }
                    else if (currentRow[1] > currentRow.Count)
                    {
                        while (currentRow[i] > currentRow[i + 1]){

                        }
                        if (currentRow[i] != currentRow[i + 1] || (currentRow[i] - currentRow[i + 1])! > 3 && currentRow[i] > currentRow[i + 1])
                        {
                            unSafe += 1;
                        }
                    }
                    else if (currentRow[1] < currentRow.Count)
                    {
                        if (currentRow[i] != currentRow[i + 1] || (currentRow[i] - currentRow[i + 1])! > 3 && currentRow[i] < currentRow[i + 1])
                        {
                            unSafe += 1;
                        }
                    }
                }


            }


        }
    }
}
