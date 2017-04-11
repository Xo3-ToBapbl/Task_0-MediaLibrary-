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
    class Event: CollectionLibrary, ILibrary
    {
        public string Name { get; set; }
        private List<Media> EventMediaElementList = new List<Media>();

        public Event(string name, List<Media> media_element_list)
        {
            Name = name;
            EventMediaElementList = media_element_list;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Event library '{0}' media elements:", Name);
            foreach (Media MediaElement in EventMediaElementList)
                Console.WriteLine("{0} - {1}", MediaElement.MediaObject, MediaElement.Name);
            Console.WriteLine("\n");
        }
    }
}
