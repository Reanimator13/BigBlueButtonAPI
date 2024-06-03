using System;
using System.ComponentModel;
using System.Xml.Serialization;
using BigBlueButtonAPI.Utils;

namespace BigBlueButtonAPI.Responses;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
public class BaseResponse
{
    [XmlElement("version")]
    public string Version { get; set; }

    [XmlElement("returncode")]
    public ReturnCode ReturnCode { get; set; }

    [XmlElement("messageKey")]
    public string MessageKey { get; set; }

    [XmlElement("message")]
    public string Message { get; set; }
}

public static class BaseResponseParser
{
    /// <summary>
    /// Parses the XML string and returns the deserialized object.
    /// </summary>
    /// <typeparam name="T">The type of the response object.</typeparam>
    /// <param name="xml">The XML string to parse.</param>
    /// <returns>The deserialized response object.</returns>
    public static T Parse<T>(string xml)
        where T : BaseResponse
    {
        return XmlSerializerHelper.DeserializeXml<T>(xml);
    }
}
