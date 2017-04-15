using MediaLibrary.Interfaces;

namespace MediaLibrary.MediaElements
{
    // Base class for media elements
    public abstract class Media: IMedia
    {
        public object MediaObject { get; }
        public string Name { get; }
        public string URL { get; }

        protected Media(object obj, string name, string url)
        {
            MediaObject = obj;
            Name = name;
            URL = url;
        }
    }
}
