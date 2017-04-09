using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;

namespace MediaLibrary.MediaElements
{
    // Base class for media elements
    public abstract class Media: IMedia
    {
        public object MediaObject { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        protected Media(object obj, string name, string url)
        {
            MediaObject = obj;
            Name = name;
            URL = url;
        }
    }
}
