using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement has two parts a condition then an action if true 
            bool isMale = true;  //boolean variable 
            bool isTall = true;

            if (isMale && isTall)//putting a condition in the para //will only print if condition is true //&& = and || Or operator 
            {
                Console.WriteLine("You are a tall male");

            }
            else if (isMale && !isTall)//! operator NOT TALL 
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");//if both false it will print the statement 
            }

            //test the above method by changing around true and false



            Console.ReadLine();
           
        }
    }
}
