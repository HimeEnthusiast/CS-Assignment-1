using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp
{
    class Account
    {
        //declaring a field or instance varibale
       private string name;
        //null or default constructor
        public Account()
        {
            Console.WriteLine("Account object initialized");
        }
        //parameterized constructor 
        public Account(string n)
        {
            name = n;
        }
        //To create a property with a setter and a getter methods
        public string Name{
            set;
            get;
        }
        //declaring a destructor
        ~Account()
        {
            Console.WriteLine("Memory removed");
        }
        //To set the name
       /* public void setName(string n)
        {
            name = n;
        }
        //To get the name 
        public string getName()
        {
            /*if (name == null)
            {
                name = "Vinay";
            }
                return name;
            
        }*/

    }
}
