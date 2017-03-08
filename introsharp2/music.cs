using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToSharpEX2
{
    public class MusicCollection
    {
        private TrackData[] tracks;
        private int cursor = 0;


        private void Resize(int newSize)
        {
            // copy into a new array
            TrackData[] temp = new TrackData[newSize];
            for (int i = 0; i < tracks.Length; ++i)
            {
                temp[i] = tracks[i];
            }

            tracks = temp;
        }
        private void Remove(int trackIndex)
        {
            for (int i = trackIndex + 1; i < tracks.Length; ++i)
            {
                tracks[i - 1] = tracks[i];
            }
        }

        public int AddTrack(TrackData track)
        {
            if (tracks == null)
            {
                tracks = new TrackData[1];
            }
            else if (cursor >= tracks.Length)
            {
                Resize(cursor + 1);
            }

            tracks[cursor] = track;
            int pos = cursor;
            cursor++;
            return pos;
        }
        public void RemoveTrack(int trackNumber)
        {
            Remove(trackNumber);
            cursor -= 1;
        }
        public float GetTotalDuration()
        {
            float total = 0;

            for (int i = 0; i < cursor; ++i)
            {
                total += tracks[i].trackDuration;
            }

            return total;
        }
        public int GetTrackCount()
        {
            return cursor;
        }
        public TrackData GetTrackAt(int trackNumber)
        {
            return tracks[trackNumber];
        }
    }
}