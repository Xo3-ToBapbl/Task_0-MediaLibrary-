using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;

namespace MediaLibrary.BuilderMediaCollections
{
    // Collection library builder
    public abstract class CollectionLibraryBuilder
    {
        protected CollectionLibrary colllib;
        public CollectionLibrary CollLib { get { return colllib; } }

        public abstract void AddPhoto(List<Media> list);
        public abstract void AddMusic(List<Media> list);
        public abstract void AddVideo(List<Media> list);
    }
}
