using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButton.Responses;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
public class PublishRecordingsResponse : BaseResponse
{
    [XmlElement("published")]
    public bool Published { get; set; }
}
