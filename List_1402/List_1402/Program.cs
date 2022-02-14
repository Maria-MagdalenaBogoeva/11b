using System;
using System.Collections.Generic;
using System.Linq;

namespace List_1402
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd=="end")
                {
                    break;
                }
                string[] tokens = cmd.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int addNums = int.Parse(tokens[1]);
                        num.Add(addNums);
                        break;
                    case "Remove":
                        int numRemove = int.Parse(tokens[1]);
                        num.Remove(numRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        num.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        num.Insert(numToInsert, indexToInsert);
                        break;
                       
                        
                }
                Console.WriteLine(string.Join(" ",num));
            }

        }
    }
}
