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
public class GetRecordingTextTracksResponse : BaseResponse
{
    [XmlElement("tracks")]
    public List<RecordingTrack> Tracks { get; set; }
}
