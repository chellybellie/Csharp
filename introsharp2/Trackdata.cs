using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToSharpEX2
{
    public struct TrackData
    {
        public string trackName;
        public string artistName;
        public string albumName;

        public float trackDuration;
        public int trackNumber;

        public TrackData(string track)
            : this(track, 0.0f)
        {

        }
        public TrackData(string track, float duration)
            : this(track, duration, "")
        {

        }
        public TrackData(string track, float duration, string artist)
            : this(track, duration, artist, "")
        {

        }
        public TrackData(string track, float duration, string artist, string album)
            : this(track, duration, artist, album, 0)
        {

        }
        public TrackData(string track, float duration, string artist, string album, int number)
        {
            trackName = track;
            artistName = artist;
            albumName = album;
            trackDuration = duration;
            trackNumber = number;
        }

        public static bool operator ==(TrackData lhs, TrackData rhs)
        {
            return lhs.trackName == rhs.trackName &&
                lhs.artistName == rhs.artistName &&
                lhs.albumName == rhs.albumName &&
                lhs.trackDuration == rhs.trackDuration &&
                lhs.trackNumber == rhs.trackNumber;
        }
        public static bool operator !=(TrackData lhs, TrackData rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            return obj is TrackData && this == (TrackData)obj;
        }
        public override int GetHashCode()
        {
            return trackName.GetHashCode() ^ artistName.GetHashCode() ^
                   albumName.GetHashCode() ^ trackDuration.GetHashCode() ^
                   trackNumber.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} secs", artistName, albumName, trackNumber, trackName, trackDuration);
        }
    }
}