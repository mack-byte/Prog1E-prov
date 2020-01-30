using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgEprov
{
    class Program
    {
        static void Main(string[] args)
        {
            Superguy sg = new Superguy();
            Megawoman mw = new Megawoman();

            Console.WriteLine("Would you like to play as a Superguy or a Megawoman");
            Console.WriteLine("Press 1 for Superguy, Press 2 for Megawoman");
            string input = Console.ReadLine();
            int gameloop = 1;
            while (gameloop == 1)
            {
                if (input == "1")
                {
                    Console.WriteLine("What would you like to be called"); 
                    string input1 = Console.ReadLine();
                    sg.name = input1;
                    Console.WriteLine("Your name is now " + sg.name);
                    Console.WriteLine("Your hp is " + sg.hp);
                    gameloop++;

                }
                if (input == "2")
                {
                    Console.WriteLine("What would you like to be called");
                    string input2 = Console.ReadLine();
                    mw.name = input2;
                    Console.WriteLine("Your name is now " + mw.name);
                    Console.WriteLine("Your hp is " + mw.hp);
                    gameloop++;
                   

                }
               
            }
            
            Console.ReadLine();

        }
    }
}
