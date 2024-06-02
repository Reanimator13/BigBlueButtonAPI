using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButton.Responses;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
public class IsMeetingRunningResponse : BaseResponse
{
    [XmlElement("running")]
    public bool Running { get; set; }
}
