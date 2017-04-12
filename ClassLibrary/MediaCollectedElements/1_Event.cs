﻿using System;
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
        private ICollection<Media> EventMediaCollection;

        public string Name { get; } 
        public ICollection<Media> MediaElementCollection
        {
            get
            {
                return new List<Media>(EventMediaCollection);
            }
        }

        public Event(string name, ICollection<Media> media_element_list)
        {
            Name = name;
            EventMediaCollection = media_element_list;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Event library '{0}' media elements:", Name);
            foreach (Media MediaElement in EventMediaCollection)
                Console.WriteLine("{0} - {1}", MediaElement.MediaObject, MediaElement.Name);
            Console.WriteLine("\n");
        }
    }
}
