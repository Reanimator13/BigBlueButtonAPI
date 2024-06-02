using System.Xml.Serialization;

namespace BigBlueButton.Responses;

public class UpdateRecordingsResponce : BaseResponse
{
    [XmlElement("updated")]
    public bool? Updated { get; set; }
}
