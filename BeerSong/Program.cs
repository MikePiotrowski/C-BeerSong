// 12/28/2022
// Michael Lee Piotrowski

using System;
using System.Threading;

public class BeerSong
{
    public static void Main(string[] args)
    {
        Action<int> printSong = numOfBeers => {
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
            Thread.sleep(4000); // Pause for seconds after every numbered bottle of beer.
        }
    }
}
