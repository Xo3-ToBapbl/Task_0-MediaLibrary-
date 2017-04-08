using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;

namespace MediaLibrary.MediaElements
{
    abstract class Media
    {
        public object MediaObject { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        protected Media(object obj, string name, string url )
        {
            MediaObject = obj;
            Name = name;
            URL = url;
        }
    }

    class Photo : Media
    {
        public Photo(object obj, string name, string url) : base(obj, name, url)
        {
        }        
    }
    class Music : Media
    {
        public Music(object obj, string name, string url) : base(obj, name, url)
        {
        }
    }
    class Video : Media
    {
        public Video(object obj, string name, string url) : base(obj, name, url)
        {
        }
    }
}
