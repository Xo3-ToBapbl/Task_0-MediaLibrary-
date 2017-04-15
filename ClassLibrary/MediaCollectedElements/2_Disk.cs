using System.Collections.Generic;
using MediaLibrary.MediaElements;

namespace MediaLibrary.MediaCollectedElements
{
    public sealed class Disk : CollectionLibrary
    {
        public Disk(string name, ICollection<Media> media_element_list) : base(name, media_element_list)
        {
        }
    }
}
