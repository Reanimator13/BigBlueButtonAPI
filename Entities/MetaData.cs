using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BigBlueButtonAPI.Entities;

public class MetaData : Dictionary<string, string>, IXmlSerializable
{
    public XmlSchema GetSchema()
    {
        return null;
    }

    public void ReadXml(XmlReader reader)
    {
        if (reader.IsEmptyElement || reader.Read() == false)
            return;

        while (reader.NodeType != XmlNodeType.EndElement)
        {
            if (reader.NodeType == XmlNodeType.Element)
            {
                this[reader.Name] = reader.ReadElementContentAsString();
            }
            else
            {
                reader.Read();
            }
        }
        reader.ReadEndElement();
    }

    public void WriteXml(XmlWriter writer)
    {
        throw new System.NotImplementedException();
    }
}
