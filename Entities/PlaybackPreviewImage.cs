using System.Xml.Serialization;

namespace BigBlueButtonAPI.Entities
{
    [XmlRoot("image")]
    public class PlaybackPreviewImage
    {
        [XmlAttribute("alt")]
        public string Alt { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlText]
        public string Url { get; set; }
    }
}
