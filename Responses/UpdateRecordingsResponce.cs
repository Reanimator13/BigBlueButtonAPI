using System.Xml.Serialization;

namespace BigBlueButtonAPI.Responses;

public class UpdateRecordingsResponce : BaseResponse
{
    [XmlElement("updated")]
    public bool Updated { get; set; }
}
