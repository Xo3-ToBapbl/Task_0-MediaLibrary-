using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;
using MediaLibrary.MediaElements;
using MediaLibrary.MediaCollectedElements;

namespace MediaLibrary.CreaterMediaCollections
{
    // Concrete media library builders
    public sealed class EventCreater : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;       
        public override string Name { get; set; }

        public EventCreater(string name, ICollection<Media> media_element_list)
        {
            Name = name;
            MediaElementList = media_element_list;
        }              
        public override ILibrary CreateMediaCollection()
        {
            if (MediaElementList.All(media_element => media_element is Photo || media_element is Video))
            {
                return new MediaCollectedElements.Event(Name, MediaElementList);
            }
            else
            {
                Console.WriteLine("Your media collection '{0}' is not created.\nReason: Unknow media file.", Name);
                Console.WriteLine("\n");
                return null;
            }
                                                             
        }
    }
    public sealed class DiskCreater : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;
        public override string Name { get; set; }

        public DiskCreater(string name, ICollection<Media> media_element_list)
        {
            Name = name;
            MediaElementList = media_element_list;
        }
        public override ILibrary CreateMediaCollection()
        {
            if (MediaElementList.All(media_element => media_element is MusicTrack || media_element is Photo))
            {
                return new MediaCollectedElements.Disk(Name, MediaElementList);
            }
            else
            {
                Console.WriteLine("Your media collection '{0}' is not created.\nReason: Unknow media file.", Name);
                Console.WriteLine("\n");
                return null;
            }
        }
    }
    public sealed class SerialCreater : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;
        public override string Name { get; set; }

        public SerialCreater(string name, ICollection<Media> media_element_list)
        {
            Name = name;
            MediaElementList = media_element_list;
        }
        public override ILibrary CreateMediaCollection()
        {
            if (MediaElementList.All(media_element => media_element is Video || media_element is Photo))
            {
                return new MediaCollectedElements.Serial(Name, MediaElementList);
            }
            else
            {
                Console.WriteLine("Your media collection '{0}' is not created.\nReason: Unknow media file.", Name);
                Console.WriteLine("\n");
                return null;
            }
        }
    }
    public sealed class SelectionCreater : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;
        public override string Name { get; set; }

        public SelectionCreater(string name, ICollection<Media> media_element_list)
        {
            Name = name;
            MediaElementList = media_element_list;
        }
        public override ILibrary CreateMediaCollection()
        {
            if (MediaElementList.All(media_element => media_element is MusicTrack || media_element is Photo))
            {
                return new MediaCollectedElements.Selection(Name, MediaElementList);
            }
            else
            {
                Console.WriteLine("Your media collection '{0}' is not created.\nReason: Unknow media file.", Name);
                Console.WriteLine("\n");
                return null;
            }
        }
    }
}
