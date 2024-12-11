namespace AVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>(File.ReadAllLines("C:\\Users\\ellio\\Documents\\Repos\\AVC\\input.txt"));
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int total = new int();

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

            for (int i = 0; i < list1.Count; i++)
            {
                total = total + Math.Abs(list1[i] - list2[i]);
            }

            Console.WriteLine(total);

        }
    }
}
