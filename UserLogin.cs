//Jose Vilaplana
using System;

class Program
{
    static void Main(string[] args)
    {
        string user, password;
        bool done = false;
        byte count = 0;

        //CORRECT USER -> Root
        //CORRECT PASS -> 1234

        do
        {
            Console.Clear();
            Console.WriteLine("Enter the user");
            Console.Write("USER: ");
            user = Console.ReadLine();
            Console.WriteLine("Enter the password");
            Console.Write("PASSWORD: ");
            password = Console.ReadLine();

            if (user == "Root" && password == "1234")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("User or Password incorrect");
                Console.ReadLine();
            }
                
            count++;
        } while (!done && count < 3);

        if (!done || count == 3)
        {
            Console.Clear();
            Console.WriteLine("Permission Denied.");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You're in!.");
            Console.ReadLine();
        }
            
            

    }
}
