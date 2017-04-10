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
        public abstract CollectionLibrary CreateMediaCollection(List<Media> list);        
    }
}
