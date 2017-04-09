using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;

namespace MediaLibrary.MediaElements
{
    public sealed class Photo : Media
    {
        public Photo(object obj, string name, string url) : base(obj, name, url)
        {
        }        
    }
    public sealed class MusicTrack : Media
    {
        public MusicTrack(object obj, string name, string url) : base(obj, name, url)
        {
        }
    }
    public sealed class Video : Media
    {
        public Video(object obj, string name, string url) : base(obj, name, url)
        {
        }
    }
}
