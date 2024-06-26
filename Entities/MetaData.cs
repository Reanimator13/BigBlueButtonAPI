﻿using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BigBlueButtonAPI.Entities;

public class Metadata : Dictionary<string, string>, IXmlSerializable
{
    public XmlSchema GetSchema() => null;

    public void ReadXml(XmlReader reader)
    {
        if (reader.IsEmptyElement || !reader.Read())
            return;

        while (reader.NodeType != XmlNodeType.EndElement)
        {
            if (reader.NodeType == XmlNodeType.Element)
            {
                Add(reader.Name, reader.ReadElementContentAsString());
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
        foreach (var keyValuePair in this)
        {
            writer.WriteElementString(keyValuePair.Key, keyValuePair.Value);
        }
    }
}
