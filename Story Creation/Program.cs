using Microsoft.VisualBasic;
using System;
using System.Threading.Tasks.Dataflow;

namespace Story_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your superpower?");
            string power = Console.ReadLine();
            Console.WriteLine("What is your unbeatable weapon?");
            string weapon = Console.ReadLine();
            Console.WriteLine("Who is your nemesis?");
            string enemy = Console.ReadLine();
       


            Console.WriteLine("Once upon a time there was someone called "  + name +   " he was "  + age +  " years old and lived with his mum and dad. One day " + enemy + " flew over to the city he was living in and decided to burn it to ashes. "  + name +  " came along and with his "  + power +  " and " + weapon + " slayed the mighty " + enemy + " and everyone lived happily every after.");
        }
    }
}
