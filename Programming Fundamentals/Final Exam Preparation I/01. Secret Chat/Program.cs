using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands != "Reveal")
            {
                // :|:
                string[] cmdTokens = commands.Split(":|:");
                // Change All
                switch (cmdTokens[0])
                {
                    case "ChangeAll":
                        {
                            // to take the substring that need to be replaced
                            string substring = cmdTokens[1]; // V
                                                             // take the replacement string
                            string replacement = cmdTokens[2];
                            message = message.Replace(substring, replacement);
                        }
                        break;

                    case "Reverse":
                        {
                            // Reverse=[0], {substring}= [1]
                            // substring = !gnil
                            string substring = cmdTokens[1];
                            if (message.Contains(substring))
                            {
                                // hellodar!gnil
                                int index = message.IndexOf(substring);
                                message = message.Remove(index, substring.Length);
                                //ling!
                                message = $"{message}{string.Join("", substring.Reverse())}";
                            }
                            else
                            {
                                Console.WriteLine("error");
                                commands = Console.ReadLine();
                                continue;
                            }
                            break;
                        }
                    case "InsertSpace":
                        {
                            int index = int.Parse(cmdTokens[1]);
                            message = message.Insert(index, " ");
                            break;
                        }
                }

                Console.WriteLine(message);
                commands = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
