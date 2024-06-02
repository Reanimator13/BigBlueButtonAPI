using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonAPI.Responses;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
public class JoinMeetingResponse : BaseResponse
{
    [XmlElement("meetingID")]
    public string MeetingId { get; set; }

    [XmlElement("user_id")]
    public string UserId { get; set; }

    [XmlElement("auth_token")]
    public string AuthToken { get; set; }

    [XmlElement("session_token")]
    public string SessionToken { get; set; }

    [XmlElement("url")]
    public string Url { get; set; }
}
