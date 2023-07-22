using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// 7-byte representation of 7-day week (Sun-Sat)        
    /// </summary>
    /// <example>
    /// For example: 1001001
    /// 0=No 1=Yes
    /// </example>
    public struct DayOfWeekType : IXmlSerializable
    {
        public bool Sunday { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }



        public readonly XmlSchema? GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();

            bool isEmptyElement = reader.IsEmptyElement;
            reader.ReadStartElement();

            if (!isEmptyElement)
            {
                string content = reader.ReadContentAsString().Trim();
                char[] bits = content.ToCharArray();

                if (bits.Length == 7)
                {
                    Sunday = bits[0] == '1';
                    Monday = bits[1] == '1';
                    Tuesday = bits[2] == '1';
                    Wednesday = bits[3] == '1';
                    Thursday = bits[4] == '1';
                    Friday = bits[5] == '1';
                    Saturday = bits[6] == '1';
                }

                reader.ReadEndElement();
            }
        }

        public readonly void WriteXml(XmlWriter writer)
        {
            char[] bits = new[]
            {
                Sunday ? '1' : '0',
                Monday ? '1' : '0',
                Tuesday ? '1' : '0',
                Wednesday ? '1' : '0',
                Thursday ? '1' : '0',
                Friday ? '1' : '0',
                Saturday ? '1' : '0',
            };

            writer.WriteString(new string(bits));
        }
    }
}
