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
        public virtual void ShowInfo()
        {
            Console.WriteLine("Your media collection is not created.\nReason: Unknow media file.");
        }
    }
}

