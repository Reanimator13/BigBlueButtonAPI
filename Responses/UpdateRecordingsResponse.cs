using System.Xml.Serialization;

namespace BigBlueButtonAPI.Responses;

public class UpdateRecordingsResponse : BaseResponse
{
    [XmlElement("updated")]
    public bool Updated { get; set; }
}
