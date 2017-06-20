using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string if; //If I uncomment this line, it will cause an Error because If is a keyword
            string @if;    //It will not provide any error, because we use @ before if

            @if = "conversation-like console program that asks users different questions.PRESS ENTER to answer the following question";
            Console.WriteLine(@if);
            Console.ReadKey();

            Console.Write("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);

            Console.Write("what is your state of Origine?");
            string state = Console.ReadLine();
            Console.WriteLine(state);

            Console.Write("How many head do you have?");
            string head = Console.ReadLine();
            Console.WriteLine(head);

            Console.Write("Are you married?");
            string married = Console.ReadLine();
            Console.WriteLine(married);

            Console.Write("what is you favourit color");
            string color = Console.ReadLine();
            Console.WriteLine(color);

            Console.Write("Thank you for answering our questions, we'll get back to you shortly");
            string You = Console.ReadLine();

        }
    }
}
