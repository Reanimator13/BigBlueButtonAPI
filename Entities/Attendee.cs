using System.Xml.Serialization;

namespace BigBlueButtonAPI.Responses;

public class Attendee
{
    [XmlElement("userID")]
    public string UserId { get; set; } = string.Empty;

    [XmlElement("fullName")]
    public string FullName { get; set; } = string.Empty;

    [XmlElement("role")]
    public Role Role { get; set; } = Role.VIEWER;

    [XmlElement("isPresenter")]
    public bool? IsPresenter { get; set; }

    [XmlElement("isListeningOnly")]
    public bool? IsListeningOnly { get; set; }

    [XmlElement("hasJoinedVoice")]
    public bool? HasJoinedVoice { get; set; }

    [XmlElement("hasVideo")]
    public bool? HasVideo { get; set; }

    [XmlElement("clientType")]
    public string ClientType { get; set; } = string.Empty;
}
