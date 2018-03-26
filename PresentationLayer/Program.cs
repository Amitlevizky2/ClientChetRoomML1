using System;
using LogicLayer;

namespace PresentationLayer
{
    class Introduction
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the chet");

            Console.WriteLine("Please choose one of the options below:");
            Console.WriteLine("a. Registration");
            Console.WriteLine("b. Login/Logout");
            Console.WriteLine("c. Retrive last 10 messages from server");
            Console.WriteLine("d. Display last 20 retrived messages sorted by the message timestamp");
            Console.WriteLine("f. Write a new message");
            Console.WriteLine("g. Exit");
            String userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "a":
                    Console.WriteLine("No problam, please fill up the next identification details: ");
                    Console.WriteLine("Nickname: ");
                    String nickname = Console.ReadLine();
                    Console.WriteLine("group ID: ");
                    int groupID = Convert.ToInt32(Console.ReadLine());
                    break;
                
                case "b":
                    
                        Console.WriteLine("That's it for now");

                    break;
                    
            }
        }
    }
}
