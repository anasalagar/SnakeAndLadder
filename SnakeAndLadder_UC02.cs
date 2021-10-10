using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        { const int POSITION = 0;
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            

            Console.WriteLine("******WELCOME******\nSnake And Ladder");
            Random r = new Random();
            int player = r.Next(0, 6) + 1;
            Console.WriteLine("The number is : " + player);
            Console.ReadLine();
        }
    }
}
