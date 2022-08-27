using System;
using System.Linq;

namespace _01._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string receivedPassword = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Complete")
            {

                if (command.Contains("Make Upper"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                    string replaceLetter = receivedPassword[index].ToString().ToUpper();

                    if (index >= 0 && index < receivedPassword.Length)
                    {
                        receivedPassword = receivedPassword.Remove(index, 1);
                        receivedPassword = receivedPassword.Insert(index, replaceLetter);
                        Console.WriteLine(receivedPassword);
                    }
                }

                else if (command.Contains("Make Lower"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (index >= 0 && index < receivedPassword.Length)
                    {
                        string replaceLetter = receivedPassword[index].ToString().ToLower();
                        receivedPassword = receivedPassword.Remove(index, 1);
                        receivedPassword = receivedPassword.Insert(index, replaceLetter);
                        Console.WriteLine(receivedPassword);
                    }
                }

                else if (command.Contains("Insert"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    string character = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

                    if (index >= 0 && index < receivedPassword.Length)
                    {
                        receivedPassword = receivedPassword.Insert(index, character);
                        Console.WriteLine(receivedPassword);
                    }
                }

                else if (command.Contains("Replace"))
                {
                    char givenChar = char.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    int value = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (receivedPassword.Contains(givenChar))
                    {
                        char newSymbol = (char)(givenChar + value);
                        receivedPassword = receivedPassword.Replace(givenChar, newSymbol);
                        Console.WriteLine(receivedPassword);
                    }
                }

                else if (command.Contains("Validation"))
                {
                    if (receivedPassword.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    if (!receivedPassword.All(x => char.IsLetterOrDigit(x) || x == '_'))
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    if (!receivedPassword.Any(x => char.IsUpper(x)))
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    if (!receivedPassword.Any(x => char.IsLower(x)))
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    if (!receivedPassword.Any(x => char.IsDigit(x)))
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }

                command = Console.ReadLine();
            }

        }
    }
}
