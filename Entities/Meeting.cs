using System.Collections.Generic;
using System.Xml.Serialization;
using BigBlueButtonAPI.Responses;

namespace BigBlueButtonAPI.Entities;

public class Meeting : BaseResponse
{
    [XmlElement("meetingName")]
    public string MeetingName { get; set; }

    [XmlElement("meetingID")]
    public string MeetingId { get; set; }

    [XmlElement("internalMeetingID")]
    public string InternalMeetingId { get; set; }

    [XmlElement("createTime")]
    public long CreateTime { get; set; }

    [XmlElement("createDate")]
    public string CreateDate { get; set; }

    [XmlElement("`voiceBridge`")]
    public int VoiceBridge { get; set; }

    [XmlElement("dialNumber")]
    public string DialNumber { get; set; }

    [XmlElement("attendeePW")]
    public string AttendeePW { get; set; }

    [XmlElement("moderatorPW")]
    public string ModeratorPW { get; set; }

    [XmlElement("running")]
    public bool Running { get; set; }

    [XmlElement("duration")]
    public int Duration { get; set; }

    [XmlElement("hasUserJoined")]
    public bool HasUserJoined { get; set; }

    [XmlElement("recording")]
    public bool Recording { get; set; }

    [XmlElement("hasBeenForciblyEnded")]
    public bool HasBeenForciblyEnded { get; set; }

    [XmlElement("startTime")]
    public long StartTime { get; set; }

    [XmlElement("endTime")]
    public long EndTime { get; set; }

    [XmlElement("participantCount")]
    public int ParticipantCount { get; set; }

    [XmlElement("listenerCount")]
    public int ListenerCount { get; set; }

    [XmlElement("voiceParticipantCount")]
    public int? VoiceParticipantCount { get; set; }

    [XmlElement("videoCount")]
    public int VideoCount { get; set; }

    [XmlElement("maxUsers")]
    public int MaxUsers { get; set; }

    [XmlElement("moderatorCount")]
    public int ModeratorCount { get; set; }

    [XmlArray("attendees")]
    [XmlArrayItem("attendee")]
    public List<Attendee> Attendees { get; set; }

    [XmlElement("metadata")]
    public MetaData MetaData { get; set; }

    [XmlElement("isBreakout")]
    public bool IsBreakout { get; set; }
}
