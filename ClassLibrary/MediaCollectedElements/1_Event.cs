using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;
using MediaLibrary.BuilderMediaCollections;
using MediaLibrary.MediaElements;

namespace MediaLibrary.MediaCollectedElements
{
    class Event: CollectionLibrary
    {
        
        private List<Media> EventElementList = new List<Media>();
        public Event(List<Media> media_element_list)
        {            
            EventElementList = media_element_list;
        }
    }
}
