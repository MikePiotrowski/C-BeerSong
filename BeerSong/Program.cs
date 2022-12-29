// 12/28/2022
// Michael Lee Piotrowski

using System;
using System.Threading;

public class BeerSong
{
    public static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(today);
        Console.ResetColor(); // The current date and time will be output in red
        Console.WriteLine();

        Action<int> printSong = numOfBeers => {

            Console.ForegroundColor = ConsoleColor.Green; // All text will be in green.
            string bottlePluralization = (numOfBeers == 1) ? "bottle" : "bottles";
            string song = numOfBeers + " " + bottlePluralization + " of beer on the wall, "
                         + numOfBeers + " " + bottlePluralization + " of beer.\n"
                         + "Take one down, pass it around, ";

            if (numOfBeers > 1)
            {
                bottlePluralization = (numOfBeers - 1 == 1) ? "bottle" : "bottles";
                song += (numOfBeers - 1) + " " + bottlePluralization + " of beer on the wall.";
            }
            else
            {
                song += "no more bottles of beer on the wall.";
            }
            Console.WriteLine(song);
        };

        for (int numOfBeers = 99; numOfBeers > 0; numOfBeers--)
        {
            printSong(numOfBeers);
            Thread.Sleep(4000); // Pause for 4 seconds between each bottle of beer.
        }
    }
}

