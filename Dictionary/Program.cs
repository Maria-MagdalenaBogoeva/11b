using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> emails = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split();


                switch (input[0])
                {
                    case "Add":
                        var mail = input[1];
                       // var count = int.Parse(input[2]);

                        if (!mail.Contains("@"))
                        {
                            Console.WriteLine("Input is not correct!");
                        }
                        else if (!emails.ContainsKey(mail))
                        {
                           // emails[mail] = mail;
                            //emails.Add(mail, int.Parse(null));
                            //emails.AddElement(mail);
                            emails.Add(mail, default(int));
                        }
                        else
                        {
                            Console.WriteLine($"{mail} already exists!.");
                        }
                        break;
                    case "Recieve":
                        var letters = input[1];
                        var countLettersRecieved = int.Parse(input[2]);
                        if (!emails.ContainsKey(letters) && letters.Contains("@"))
                        { 
                            emails.Add(letters, countLettersRecieved);
                        }
                        else if (emails.ContainsKey(letters))
                        {
                            emails[letters] += countLettersRecieved;
                        }
                        else
                        {

                        }
                        break;
                    case "Sent":
                        var email = input[1];
                        var countLettersSent = int.Parse(input[2]);
                        if (emails.ContainsKey(email))
                        {
                           // emails[countLettersSent] -= countLettersRecieved;
                        }
                        else
                        {
                            emails[email] = countLettersSent;
                        }

                       
                        break;
                    case "List":                     
                        foreach (var em in emails)
                        {
                            string emaill = em.Key;
                            int num = em.Value;
                            Console.WriteLine($"{emaill} -> {num}");
                        }
                        break;

                    default:
                        break;
                }
            }

        }
    }
}

