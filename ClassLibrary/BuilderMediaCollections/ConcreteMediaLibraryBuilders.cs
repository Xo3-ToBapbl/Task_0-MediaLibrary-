using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;
using MediaLibrary.MediaElements;

namespace MediaLibrary.BuilderMediaCollections
{
    // Concrete media library builders
    public sealed class EventBuilder : CollectionLibraryBuilder, ILibrary
    {
        public string name { get; set; }
        public EventBuilder(string name)
        {
            this.name = name;
            colllib = new CollectionLibrary(this.name);
        }
        public override void AddMusic(List<Media> list)
        {
        }
        public override void AddPhoto(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Photo)
                    colllib.Add(element);
            }
        }
        public override void AddVideo(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Video)
                    colllib.Add(element);
            }
        }
    }
    public sealed class DiskBuilder : CollectionLibraryBuilder, ILibrary
    {
        public string name { get; set; }
        public DiskBuilder(string name)
        {
            this.name = name;
            colllib = new CollectionLibrary(this.name);
        }
        public override void AddMusic(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is MusicTrack)
                    colllib.Add(element);
            }
        }
        public override void AddPhoto(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Photo)
                    colllib.Add(element);
            }
        }
        public override void AddVideo(List<Media> list)
        {
        }
    }
    public sealed class SerialBuilder : CollectionLibraryBuilder, ILibrary
    {
        public string name { get; set; }
        public SerialBuilder(string name)
        {
            this.name = name;
            colllib = new CollectionLibrary(this.name);
        }
        public override void AddMusic(List<Media> list)
        {
        }
        public override void AddPhoto(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Photo)
                    colllib.Add(element);
            }
        }
        public override void AddVideo(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Video)
                    colllib.Add(element);
            }
        }
    }
    public sealed class SelectionBuilder : CollectionLibraryBuilder, ILibrary
    {
        public string name { get; set; }
        public SelectionBuilder(string name)
        {
            this.name = name;
            colllib = new CollectionLibrary(this.name);
        }
        public override void AddMusic(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is MusicTrack)
                    colllib.Add(element);
            }
        }
        public override void AddPhoto(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Photo)
                    colllib.Add(element);
            }
        }
        public override void AddVideo(List<Media> list)
        {
        }
    }
}
