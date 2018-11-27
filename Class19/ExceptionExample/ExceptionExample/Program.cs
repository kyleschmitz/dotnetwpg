using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            
            do
            {
                Console.Write("Enter a username ('Q' to quit): ");
                Console.ReadLine();

                if (input != "Q")
                {
                    try
                    {
                        bool valid = IsUsernameValid(input);
                        if (valid)
                        {
                            Console.WriteLine("Username is valid!");
                        }
                        else
                        {
                            Console.WriteLine("Username is not valid. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An exception occurred: " + ex.Message);
                    }
                }
            } while (input != "Q");

            Console.ReadKey();
        }

        static bool IsUsernameValid(string username)
        {
            bool valid = true;

            if (CheckForValidCharacters(username) == false)
            {
                valid = false;
            }
            else if (username.Length < 6)
            {
                valid = false;
            }

            return valid;
        }

        static bool CheckForValidCharacters(string username)
        {
            bool valid = true;

            for (int i = 0; i < username.Length; i++)
            {
                if (username[i] < (char) 65 || username[i] > (char) 122)
                {
                    valid = false;
                    break;
                }

            }

            return valid;
        }
    }
}
