using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;

namespace MediaLibrary.MediaElements
{
    // Library director
    class LibDirector
    {
        public void Create(CollLibBuilder builder, List<Media> list)
        {
            builder.AddPhoto(list);
            builder.AddMusic(list);
            builder.AddVideo(list);
        }
    }   
    
    // Collection library builder
    abstract class CollLibBuilder
    {
        protected CollLib colllib;
        public CollLib CollLib { get { return colllib; } }

        public abstract void AddPhoto(List<Media> list);
        public abstract void AddMusic(List<Media> list);
        public abstract void AddVideo(List<Media> list);
    }
    
    // Concrete library builders
    class Event : CollLibBuilder, ILibrary
    {
        public string name { get; set; }       
        public Event(string name)
        {
            this.name = name;
            colllib = new CollLib(this.name);                    
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
    class Disk: CollLibBuilder, ILibrary
    {
        public string name { get; set; }
        public Disk(string name)
        {
            this.name = name;
            colllib = new CollLib(this.name);            
        }
        public override void AddMusic(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Music)
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
    class Serial : CollLibBuilder, ILibrary
    {
        public string name { get; set; }
        public Serial(string name)
        {
            this.name = name;
            colllib = new CollLib(this.name);            
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
    class Selection: CollLibBuilder, ILibrary
    {
        public string name { get; set; }
        public Selection(string name)
        {
            this.name = name;
            colllib = new CollLib(this.name);            
        }
        public override void AddMusic(List<Media> list)
        {
            foreach (Media element in list)
            {
                if (element is Music)
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
    
    // Product collection library
    class CollLib: ILibrary
    {        
        private List<Media> MediaParts = new List<Media>();
        public string name { get; set; }

        public CollLib(string name)
        {
            this.name = name;
        }

        public void Add(Media part)
        {
            MediaParts.Add(part);
        }
        public void ShowParts()
        {
            Console.WriteLine("{0}:", name);
            foreach (Media part in MediaParts)
                Console.WriteLine("{0} - {1}", part.MediaObject, part.Name);
            Console.WriteLine("\n");
        }
    }
}

