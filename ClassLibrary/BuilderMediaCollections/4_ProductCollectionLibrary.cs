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
    public class CollectionLibrary
    {        
        public List<Media> MediaParts = new List<Media>();    
        public void Add(Media part)
        {
            MediaParts.Add(part);
        }
        public void ShowParts()
        {            
            foreach (Media part in MediaParts)
                Console.WriteLine("{0} - {1}", part.MediaObject, part.Name);
            Console.WriteLine("\n");
        }
    }
}

