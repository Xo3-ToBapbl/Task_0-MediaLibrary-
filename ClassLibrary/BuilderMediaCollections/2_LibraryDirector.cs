﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;

namespace MediaLibrary.BuilderMediaCollections
{
    // Library director
    public sealed class LibraryDirector
    {
        public void Create(CollectionLibraryCreater builder, List<Media> media_element_list)
        {
            builder.CreateMediaCollection(media_element_list);            
        }
    }
}
