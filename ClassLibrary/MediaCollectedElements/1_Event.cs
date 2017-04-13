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
    public class Event: ILibrary
    {        
        private ICollection<Media> EventMediaCollection;

        public string Name { get; } 
        public ICollection<Media> MediaElementCollection
        {
            get
            {
                return new List<Media>(EventMediaCollection);
            }
        }

        public Event() { }
        public Event(string name, ICollection<Media> media_element_list)
        {
            Name = name;
            EventMediaCollection = media_element_list;
        }

        public void ShowInfo()
        {
            if (this != null)
            {
                Console.WriteLine("Event library '{0}' media elements:", Name);
                foreach (Media MediaElement in EventMediaCollection)
                    Console.WriteLine("{0} - {1}", MediaElement.MediaObject, MediaElement.Name);
                Console.WriteLine("\n");
            }
            else
                Console.WriteLine("Your media collection is not created.\nReason: Unknow media file.");
        }
    }
}
