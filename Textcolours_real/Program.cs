using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textcolours_real
{
    class Program
    {
        static void pushtext(ConsoleColor colour, string text)
        {
            ConsoleColor old_colour = Console.ForegroundColor;
            Console.ForegroundColor = colour;
            Console.Write(text);
            Console.ForegroundColor = old_colour;
        }
        static bool isOdd(int i)
        {
            return i % 2 != 0;
        }
        static string FizzBuzz(int no)
        {
            if (no % 3 == 0)
            {
                if (no % 5 == 0)
                {
                    return "fizzbuzz";
                }
                else
                {
                    return "fizz";
                }
            }
            else if(no % 5 == 0){
                return "buzz";
            }
            else{
                return "normal";
            }
        }
        static void Main(string[] args)
        {
            pushtext(ConsoleColor.White, "White");
            Console.Write(" is a normal number" + Environment.NewLine);
            pushtext(ConsoleColor.Green, "Green");
            Console.Write(" is a number divisible by 3" + Environment.NewLine);
            pushtext(ConsoleColor.Red, "Red");
            Console.Write(" is a number divisible by 5" + Environment.NewLine);
            pushtext(ConsoleColor.Cyan, "Cyan");
            Console.Write(" is a number divisible by both 3 and 5" + Environment.NewLine + Environment.NewLine);
            int max = 100;
            for (int x = 1; x <= max; x++)
            {
                switch (FizzBuzz(x))
                {
                    case "fizz":
                        pushtext(ConsoleColor.Green, x.ToString());
                        break;
                    case "buzz":
                        pushtext(ConsoleColor.Red, x.ToString());
                        break;
                    case "fizzbuzz":
                        pushtext(ConsoleColor.Cyan, x.ToString());
                        break;
                    case "normal":
                        pushtext(ConsoleColor.White, x.ToString());
                        break;

                }
                if (x != max)
                {
                    Console.Write(", ");
                }
            }
            Console.ReadKey();
        }
    }
}
