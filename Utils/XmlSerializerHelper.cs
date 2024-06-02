using System.IO;
using System.Xml.Serialization;

namespace BigBlueButtonAPI.Utils;

public static class XmlSerializerHelper
{
    public static T DeserializeXml<T>(string xmlInput)
    {
        var xmlSerializer = new XmlSerializer(typeof(T));
        using var stringReader = new StringReader(xmlInput);
        return (T)xmlSerializer.Deserialize(stringReader);
    }
}
