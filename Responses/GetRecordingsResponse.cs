using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Responses;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
public class GetRecordingsResponse : BaseResponse
{
    [XmlArray("recordings")]
    [XmlArrayItem("recording")]
    public List<Recording> Recordings { get; set; }
}
