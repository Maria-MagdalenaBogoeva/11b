using System;
using System.Linq;

namespace Task_0802
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string cmd = command[0];
                if (cmd == "Reverse")
                {
                    arr = arr.Reverse().ToArray();
                }
                else if (cmd=="Distinct")
                {
                   arr = arr.Distinct().ToArray();
                }
                else if(cmd=="Replace")
                {
                    int index = int.Parse(command[1]);
                    string newString = command[2];
                    arr[index] = newString;
                  
                }
            
            }
            Console.WriteLine(string.Join(",",arr));
        }
    }
}
