using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;
using MediaLibrary.Interfaces;

namespace MediaLibrary.BuilderMediaCollections
{
    // Library director
    public sealed class LibraryDirector
    {
        public ILibrary Create(CollectionLibraryCreater creater)
        {
            return creater.CreateMediaCollection();      
        }
    }
}
