using MediaLibrary.Interfaces;

namespace MediaLibrary.CreaterMediaCollections
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
