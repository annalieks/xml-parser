using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XMLParser
{
    class LinqXMLSearchStrategy : IXMLSearchStrategy
    {
        public List<Photo> Search(Photo photo)
        {
            var result = new List<Photo>();
            var document = XDocument.Load(Data.FilePath);
            var photos = (from obj in document.Descendants("Photo")
                          select new
                          {
                              Author = obj.Attribute("Author"),
                              Year = obj.Attribute("Year"),
                              City = obj.Attribute("City"),
                              Size = obj.Attribute("Size"),
                              ISO = obj.Attribute("ISO"),
                              Format = obj.Attribute("Format"),
                              Quality = obj.Attribute("Quality")
                          }).ToList();

            foreach(var linqPhoto in photos)
            {
                var xmlPhoto = new Photo();
                xmlPhoto.Author = linqPhoto.Author?.Value;
                xmlPhoto.Year = Utils.ParseToInt(linqPhoto.Year);
                xmlPhoto.City = linqPhoto.City?.Value;
                xmlPhoto.Size = Utils.ParseToInt(linqPhoto.Size);
                xmlPhoto.ISO = Utils.ParseToInt(linqPhoto.ISO);
                xmlPhoto.Format = linqPhoto.Format?.Value;
                xmlPhoto.Quality = Utils.ParseToQuality(linqPhoto.Quality);
                if (xmlPhoto.Equals(photo))
                {
                    result.Add(xmlPhoto);
                }
            }

            return result;
        }
    }
}
