using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharpExercises
{
    struct Transaction
    {
        public string itemName;
        public int itemPrice;
        public DateTime transactionDate;
    }

    class Player
    {
        public string name;
        public int guess;
    }

    class Program
    {
        static void ReverseString(ref string given)
        {
            string temp = string.Empty;

            for (int i = given.Length - 1; i >= 0; --i)
            {
                temp += given[i];
            }

            given = temp;
        }

        //static bool IsPalindrome(string given)
        //{
        //    string givenCopy = given.Clone() as string;
        //    ReverseString(ref givenCopy);

        //    return given.ToLower() == givenCopy.ToLower();
        //}
        static bool IsPalindrome(string given)
        {
            string givenLower = given.ToLower();
            for (int i = 0; i < givenLower.Length / 2; ++i)
            {
                if (givenLower[i] != givenLower[givenLower.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static Player[] GetWinner(Player[] players, int correctValue)
        {
            int smallestDelta = int.MaxValue;
            int winnerCount = 0;
            for (int i = 0; i < players.Length; ++i)
            {
                int delta = Math.Abs(correctValue - players[i].guess);
                if (delta < smallestDelta)
                {
                    smallestDelta = delta;
                    winnerCount = 1;
                }
                else if (delta == smallestDelta)
                {
                    winnerCount++;
                }
            }

            Player[] winners = new Player[winnerCount];
            int cursor = 0;
            for (int i = 0; i < players.Length; ++i)
            {
                if (Math.Abs(correctValue - players[i].guess) == smallestDelta)
                {
                    winners[cursor] = players[i];
                    cursor++;
                }
            }

            return winners;
        }

        static void ProcessTransaction(ref Transaction pendingTransaction)
        {
            pendingTransaction.transactionDate = DateTime.Now;
        }

        static void Main(string[] args)
        {
            string rev1 = "Hello";
            string rev2 = "Hotdog";
            string rev3 = "Dinogirl";
            string rev4 = "racecar";

            // no ref
            string variable = "Johnn";

            ReverseString(ref rev1);
            ReverseString(ref rev2);
            ReverseString(ref rev3);
            ReverseString(ref rev4);

            string pal1 = "racecar";
            string pal2 = "mom";
            string pal3 = "Madam";
            string pal4 = "bottle";

            if (!IsPalindrome(pal1)) { Console.WriteLine("ERROR"); }
            if (!IsPalindrome(pal2)) { Console.WriteLine("ERROR"); }
            if (!IsPalindrome(pal3)) { Console.WriteLine("ERROR"); }
            if (IsPalindrome(pal4)) { Console.WriteLine("ERROR"); }

            Player[] playersA = new Player[5];
            playersA[0] = new Player();
            playersA[0].name = "Benny S.";
            playersA[0].guess = 12;
            playersA[1] = new Player();
            playersA[1].name = "Donny T.";
            playersA[1].guess = 23;
            playersA[2] = new Player();
            playersA[2].name = "Henny C.";
            playersA[2].guess = 17;
            playersA[3] = new Player();
            playersA[3].name = "Garry J.";
            playersA[3].guess = 55;
            playersA[4] = new Player();
            playersA[4].name = "Jilly S.";
            playersA[4].guess = 3;

            Player[] playersB = new Player[4];
            playersB[0] = new Player();
            playersB[0].name = "Solly 69";
            playersB[0].guess = 69;
            playersB[1] = new Player();
            playersB[1].name = "Carhog";
            playersB[1].guess = 3;
            playersB[2] = new Player();
            playersB[2].name = "Mercay";
            playersB[2].guess = 45;
            playersB[3] = new Player();
            playersB[3].name = "G.Va";
            playersB[3].guess = 31;

            Player[] winnersA = GetWinner(playersA, 24);
            Player[] winnersB = GetWinner(playersB, 15);

            Transaction buySticky = new Transaction();
            buySticky.itemName = "Sticky Hopper";
            buySticky.itemPrice = 2;

            Transaction buyLoot = new Transaction();
            buyLoot.itemName = "Loot Container";
            buyLoot.itemPrice = 2;

            ProcessTransaction(ref buySticky);
            ProcessTransaction(ref buyLoot);

            Console.WriteLine();
            Console.Read();
        }
    }
}