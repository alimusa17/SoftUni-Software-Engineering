using System;

namespace _06._Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Decode")
                {
                    break;
                }

                string[] tokens = command.Split('|');
                string action = tokens[0];

                switch (action)
                {
                    case "Move":
                        int length = int.Parse(tokens[1]);
                        string stringToMove = message.Substring(0, length);

                        message = message.Remove(0, length);
                        break;

                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string value = tokens[2];

                        message = message.Insert(index, value);
                        break;

                    case "ChangeAll":
                        string substring = tokens[1];
                        string replacement = tokens[2];

                        message = message.Replace(substring, replacement);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}"); //TODO SS 6876!!! X 10 && video 2.30.00
        }
    }
}