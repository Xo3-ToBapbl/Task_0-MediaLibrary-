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
    public sealed class CollectionLibrary: ILibrary
    {        
        private List<Media> MediaParts = new List<Media>();
        public string name { get; set; }

        public CollectionLibrary(string name)
        {
            this.name = name;
        }

        public void Add(Media part)
        {
            MediaParts.Add(part);
        }
        public void ShowParts()
        {
            Console.WriteLine("{0}:", name);
            foreach (Media part in MediaParts)
                Console.WriteLine("{0} - {1}", part.MediaObject, part.Name);
            Console.WriteLine("\n");
        }
    }
}

