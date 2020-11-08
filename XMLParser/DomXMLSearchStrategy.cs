using System.Collections.Generic;
using System.Xml;

namespace XMLParser
{
    class DomXMLSearchStrategy : IXMLSearchStrategy
    {
        private static XmlDocument xml = new XmlDocument();
        public List<Photo> Search(Photo photo)
        {
            xml.Load(Data.FilePath);

            var result = new List<Photo>();
            var node = xml.DocumentElement;
            foreach(XmlNode childNode in node.ChildNodes)
            {
                var xmlPhoto = ProcessAttributes(childNode.Attributes);
                if (xmlPhoto.Equals(photo))
                {
                    result.Add(xmlPhoto);
                }
            }
            return result;
        }

        private Photo ProcessAttributes(XmlAttributeCollection attributes)
        {
            var result = new Photo();
            foreach(XmlAttribute attr in attributes)
            {
                result.SetAttribute(attr.Name, attr.Value);
            }
            return result;
        }
    }
}
