using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;

namespace MediaLibrary.Interfaces
{
    interface ILibrary
    {
        string Name { get; }
        ICollection<Media> MediaElementCollection { get; }
    }
}
