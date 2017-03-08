using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToSharpEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            TrackData ricky = new TrackData("Never Gonna Give You Up", 211,
                "Rick Astley", "Whenever You Need Somebody", 1);

            TrackData asc = new TrackData("All Star Circulation", 244,
    "Smash Ground vs. Kana Hanazawa", "All Star Circulation (Single)", 1);

            TrackData mos = new TrackData("Moskow");

            MusicCollection collection = new MusicCollection();
            collection.AddTrack(ricky);
            collection.AddTrack(asc);
            collection.AddTrack(mos);

            collection.RemoveTrack(1);

            collection.AddTrack(ricky);
            Console.WriteLine(ricky.ToString());
            Console.ReadLine();
        }
    }
}