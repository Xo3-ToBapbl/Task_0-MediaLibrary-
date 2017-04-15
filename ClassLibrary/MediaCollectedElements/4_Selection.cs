using System.Collections.Generic;
using MediaLibrary.MediaElements;

namespace MediaLibrary.MediaCollectedElements
{
    public sealed class Selection : CollectionLibrary
    {
        public Selection(string name, ICollection<Media> media_element_list) : base(name, media_element_list)
        {
        }
    }
}
