using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BigBlueButtonAPI.Entities;

public class PlaybackPreviewImages : List<PlaybackPreviewImage>, IXmlSerializable
{
    public XmlSchema GetSchema() => null;

    public void ReadXml(XmlReader reader)
    {
        if (reader.IsEmptyElement || !reader.Read())
            return;

        var imageSerializer = new XmlSerializer(typeof(PlaybackPreviewImage));
        while (reader.NodeType != XmlNodeType.EndElement)
        {
            if (reader.NodeType == XmlNodeType.Element && reader.Name != "images")
            {
                Add(imageSerializer.Deserialize(reader) as PlaybackPreviewImage);
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
        foreach (var image in this)
        {
            var imageSerializer = new XmlSerializer(typeof(PlaybackPreviewImage));
            imageSerializer.Serialize(writer, image);
        }
    }
}
