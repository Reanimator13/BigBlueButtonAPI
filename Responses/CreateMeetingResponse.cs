using System;
using System.ComponentModel;
using System.Xml.Serialization;
using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Responses;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
public class CreateMeetingResponse : Meeting { }
