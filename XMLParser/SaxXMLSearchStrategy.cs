using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMLParser
{
    class SaxXMLSearchStrategy : IXMLSearchStrategy
    {
        public List<Photo> Search(Photo photo)
        {
            var result = new List<Photo>();
            var xmlReader = new XmlTextReader(Data.FilePath);

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    var xmlPhoto = new Photo();
                    while (xmlReader.MoveToNextAttribute())
                    {
                        xmlPhoto.SetAttribute(xmlReader.Name, xmlReader.Value);
                    } 
                    if(xmlPhoto.Equals(photo) && !xmlPhoto.IsEmpty())
                    {
                        result.Add(xmlPhoto);
                    }
                }
            }
            xmlReader.Close();
            return result;
        }
    }
}
