using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to (S)tart or (A)bort? (Enter choice and press enter)");
            String input = Console.ReadLine().ToUpper();
            while (input != "A") {
                if (input == "S")
                {
                    Console.WriteLine(".      . .                 .   . ");
                    Console.WriteLine("|-. .-,| | .-.  . . ..-..-.| .-| ");
                    Console.WriteLine("' '-`'-'-'-`-'   ` ` `-''  '-`-'-");
                   // Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to (S)tart or (A)bort again?");
                    input = Console.ReadLine();
                }
                else if ((input != "A") || (input != "S"))
                {
                    Console.WriteLine("Invalid input, re-enter 'A' or 'S'");
                    Console.ReadLine();
                }
                }
                Environment.Exit(0);
            }
        }
    }

