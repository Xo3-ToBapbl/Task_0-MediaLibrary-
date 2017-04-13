using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;
using MediaLibrary.Interfaces;

namespace MediaLibrary.BuilderMediaCollections
{
    // Collection library builder
    public abstract class CollectionLibraryCreater
    {
        public abstract string Name {get; set;}
        public abstract ILibrary CreateMediaCollection();        
    }
}
