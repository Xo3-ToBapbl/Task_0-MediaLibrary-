using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaCollectedElements;
using MediaLibrary.MediaElements;
using System.Threading;

namespace Player
{
    public sealed class MyPlayer
    {
        private ICollection<Media> PlayList;

        public void GetPlayList(params ICollection<Media>[] MediaLists)
        {
            PlayList = MediaLists.SelectMany(x => x).Where(x => x is MusicTrack || x is Video).ToList();            
        }
        public void Play()
        {
            foreach (Media track in PlayList)
            {
                Console.WriteLine("Now playing: {0}", track.Name);
                Thread.Sleep(500);
            }
            Console.WriteLine("\nPlying stoped. End of playlist.");
        }
    }
}
