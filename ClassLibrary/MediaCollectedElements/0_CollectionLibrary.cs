using System;
using System.Collections.Generic;
using MediaLibrary.Interfaces;
using MediaLibrary.MediaElements;

namespace MediaLibrary.MediaCollectedElements
{
    // Base library class
    public class CollectionLibrary: ILibrary
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

        private CollectionLibrary() { }
        protected CollectionLibrary(string name, ICollection<Media> media_element_list)
        {
            Name = name;
            EventMediaCollection = media_element_list;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Library '{0}' media elements:", Name);
            foreach (Media MediaElement in EventMediaCollection)
                Console.WriteLine("{0} - {1}", MediaElement.MediaObject, MediaElement.Name);
            Console.WriteLine("\n");
        }
    }
}

