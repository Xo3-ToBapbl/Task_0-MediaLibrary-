using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;
using MediaLibrary.MediaElements;

namespace MediaLibrary.BuilderMediaCollections
{
    // Product collection library
    public class Event
    {
        private ICollection<Media> mediaElementList;
        private string name;

        public Event(string name, ICollection<Media> mediaElementList)
        {
            this.name = name;
            this.mediaElementList = mediaElementList;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Your media collection is not created.\nReason: Unknow media file.");
        }
    }
}

