using System;
using System.Collections.Generic;
using System.Text;

namespace XMLParser
{
    interface IXMLSearchStrategy
    {
        public List<Photo> Search(Photo photo);
    }
}
