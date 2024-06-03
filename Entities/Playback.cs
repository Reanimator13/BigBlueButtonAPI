using System.Xml.Serialization;

namespace BigBlueButtonAPI.Entities
{
    public class Playback
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("processingTime")]
        public int ProcessingTime { get; set; }

        [XmlElement("length")]
        public int Length { get; set; }

        [XmlElement("preview")]
        public PlaybackPreviewImages PreviewImages { get; set; }
    }
}
