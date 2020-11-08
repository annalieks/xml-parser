using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMLParser
{
    class Data
    {
        public static Photo SearchTarget = new Photo();

        public static string FilePath { get; private set; }

        private static XmlDocument doc = new XmlDocument();
 
        public static XmlNodeList SetPath(string path)
        {
            FilePath = path;
            doc.Load(FilePath);
            var root = doc.DocumentElement;
            return root.SelectNodes("Photo");
        }

    }
}
