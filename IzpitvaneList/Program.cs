using System;
using System.Collections.Generic;
using System.Linq;

namespace IzpitvaneList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="print")
                {
                    Console.WriteLine(String.Join(" ",names));               
                }
                if (input=="Exit")
                {
                    break;
                }
                if (int.TryParse(input,out int n)==true)
                {
                    names.Reverse();
                    break;
                }
                string[] cmd = input.Split();
                switch (cmd[0])
                {
                    case "insert":
                        string element = cmd[1];
                        int index = int.Parse(cmd[2]);
                        
                        if (!names.Contains(element))
                        {
                            names.Insert(index, element);
                        }
                        break;
                    case "delete":
                        int indexToRemove = int.Parse(cmd[1]);
                        if (indexToRemove<0||indexToRemove>names.Count)
                        {

                        }
                        else
                        {
                            names.RemoveAt(indexToRemove);
                        }
                        break;
                    case "swap":
                        string firstName = cmd[1];
                        int indexOfFirstName = names.IndexOf(firstName);
                        string secondName = cmd[2];
                        int indexOfSecondName = names.IndexOf(secondName);
                        if (names.Contains(firstName)&&names.Contains(secondName))
                        {
                            string temp = firstName;
                            names[indexOfFirstName] = secondName;
                            names[indexOfSecondName] = temp;
                        }
                        

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
