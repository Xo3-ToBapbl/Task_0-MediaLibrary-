using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.Interfaces
{
    interface IMedia
    {
        object MediaObject { get; }
        string Name { get; }
        string URL { get; }
    }
}
