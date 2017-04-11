using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;

namespace MediaLibrary.BuilderMediaCollections
{
    // Collection library builder
    public abstract class CollectionLibraryCreater
    {
        public abstract string Name {get; set;}
        public abstract CollectionLibrary CreateMediaCollection();//List<Media> media_element_list        
    }
}
