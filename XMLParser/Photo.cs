
using System;

namespace XMLParser
{
    class Photo
    {
        public string Author { get; set; }
        public int? Year { get; set; }
        public string City { get; set; }
        public int? Size { get; set; }
        public int? ISO { get; set; }
        public string Format { get; set; }
        public Quality? Quality { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Photo p = (Photo)obj;
                return (Author == p.Author || p.Author == null)
                    && (Year == p.Year || p.Year == null)
                    && (City == p.City || p.City == null )
                    && (Size == p.Size || p.Size == null)
                    && (ISO == p.ISO || p.ISO == null)
                    && (Format == p.Format || p.Format == null)
                    && (Quality == p.Quality || p.Quality == null);
            }
        }

        public void SetAttribute(string attr, string value)
        {
            switch (attr)
            {
                case "Author":
                    Author = value;
                    break;
                case "Year":
                    Year = Utils.ParseToInt(value);
                    break;
                case "City":
                    City = value;
                    break;
                case "Size":
                    Size = Utils.ParseToInt(value);
                    break;
                case "ISO":
                    ISO = Utils.ParseToInt(value);
                    break;
                case "Format":
                    Format = value;
                    break;
                case "Quality":
                    Quality = Utils.ParseToQuality(value);
                    break;
            }
        }

        public override string ToString()
        {
            return "\n"
                + "Автор: " + Author + "\n"
                + "Рік: " + Year + "\n"
                + "Місто: " + City + "\n"
                + "Розмір: " + Size + "\n"
                + "ISO: " + ISO + "\n"
                + "Формат: " + Format + "\n"
                + "Якість: " + Quality + "\n";
        }

        public bool IsEmpty()
        {
            return Author == null
                && Year == null
                && City == null
                && Size == null
                && ISO == null
                && Format == null
                && Quality == null;
        }
    }
}
