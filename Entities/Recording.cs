﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace BigBlueButtonAPI.Entities;

public class Recording
{
    [XmlElement("recordID")]
    public string RecordID { get; set; }

    [XmlElement("meetingID")]
    public string MeetingID { get; set; }

    [XmlElement("internalMeetingID")]
    public string InternalMeetingID { get; set; }

    [XmlElement("name")]
    public string Name { get; set; }

    [XmlElement("isBreakout")]
    public bool IsBreakout { get; set; }

    [XmlElement("published")]
    public bool Published { get; set; }

    [XmlElement("state")]
    public string State { get; set; }

    [XmlElement("startTime")]
    public long StartTime { get; set; }

    [XmlElement("endTime")]
    public long EndTime { get; set; }

    [XmlElement("participants")]
    public int Participants { get; set; }

    [XmlElement("metadata")]
    public Metadata? Meta { get; set; }

    [XmlArray("playback")]
    [XmlArrayItem("format")]
    public List<Playback> Playbacks { get; set; }
}
