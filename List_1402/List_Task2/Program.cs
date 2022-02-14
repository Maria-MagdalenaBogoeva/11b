using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd=="print")
                {
                    Console.WriteLine(string.Join(" ",num));
                    break;
                }
                if (int.TryParse(cmd,out int n )==true)
                {
                    num.Sort();
                    Console.WriteLine(string.Join(" ",num));
                }
                string[] tokens = cmd.Split();
                switch (tokens[0])
                {
                    
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int num1 = int.Parse(tokens[2]);
                        if (!num.Contains(num1))
                        {
                            num.Insert(index, num1);
                        }
                        break;
                    case "contains":
                        int numToSearch = int.Parse(tokens[1]);
                        if (num.Contains(numToSearch))
                        {
                            Console.WriteLine(num.IndexOf(numToSearch));
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }
                        break;
                    case "remove":
                        int index1 = int.Parse(tokens[1]);
                        if (index1 < 0 || index1 >= num.Count)
                        {
                            Console.WriteLine("Index isnt correct!");
                        }
                        else
                        {
                            num.RemoveAt(index1);
                        }
                        break;
                    case "swap":
                        int el1 = int.Parse(tokens[1]);
                        int indexOfEl1 = num.IndexOf(el1);

                        int el2 = int.Parse(tokens[2]);
                        int indexOfEl2 = num.IndexOf(el2);

                        int temp = el1;
                        num[indexOfEl1] = el2;
                        num[indexOfEl2]= temp;

                        break;
                    

                    default:
                        break;
                }
            }
        }
    }
}
