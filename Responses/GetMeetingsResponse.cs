using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using BigBlueButton.Entities;

namespace BigBlueButton.Responses;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
public class GetMeetingsResponse : BaseResponse
{
    [XmlArray("meetings")]
    [XmlArrayItem("meeting")]
    public List<Meeting> Meetings { get; set; }
}
