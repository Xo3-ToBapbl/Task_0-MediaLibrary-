using System;
using System.Collections.Generic;
using System.Linq;
using MediaLibrary.Interfaces;
using MediaLibrary.MediaElements;

namespace MediaLibrary.CreaterMediaCollections
{
    // Concrete media library creators
    public sealed class EventCreator : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;       
        public override string Name { get; set; }

        public EventCreator(string name, ICollection<Media> media_element_list)
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
    public sealed class DiskCreator : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;
        public override string Name { get; set; }

        public DiskCreator(string name, ICollection<Media> media_element_list)
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
    public sealed class SerialCreator : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;
        public override string Name { get; set; }

        public SerialCreator(string name, ICollection<Media> media_element_list)
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
    public sealed class SelectionCreator : CollectionLibraryCreater
    {
        private ICollection<Media> MediaElementList;
        public override string Name { get; set; }

        public SelectionCreator(string name, ICollection<Media> media_element_list)
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
