using System.Collections.Generic;
using MediaLibrary.MediaElements;

namespace MediaLibrary.MediaCollectedElements
{
    public sealed class Event: CollectionLibrary
    {        
        public Event(string name, ICollection<Media> media_element_list):base (name, media_element_list)
        {            
        }
    }
}
