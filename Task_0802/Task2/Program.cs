using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToArray();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string cmd = command[0];
                if (cmd=="END")
                {
                    break;
                }
                switch (cmd)
                {
                    case "Reverse":
                        arr = arr.Reverse().ToArray();
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string newString = command[2];
                        if (index>=0&&index<arr.Length)
                        {
                            arr[index] = newString;
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                    default:
                        break;
                        
                }
            }
            Console.WriteLine(string.Join(",",arr));
        }
    }
}
