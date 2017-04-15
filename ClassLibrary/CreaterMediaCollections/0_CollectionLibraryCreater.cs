using MediaLibrary.Interfaces;

namespace MediaLibrary.CreaterMediaCollections
{
    // Collection library creator
    public abstract class CollectionLibraryCreater
    {
        public abstract string Name {get; set;}
        public abstract ILibrary CreateMediaCollection();        
    }
}
