using System;

namespace AccountApp
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account = new Account("Vinay");
            //To get the value of name field
            // Console.WriteLine($"Account name:{account.getName()}");
            Console.WriteLine($"Account name:{account.Name}");


            //To get name from user as an input
            Console.WriteLine("Give an input");
            string name = Console.ReadLine();
            account.Name=name;

            Console.WriteLine($"Account name:{account.Name}");

        }
    }
}
