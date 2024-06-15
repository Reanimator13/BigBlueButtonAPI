namespace BigBlueButtonAPI.Requests;

public class GetRecordingTextTracksRequest
{
    /// <summary>
    /// [Required] A single recording ID to retrieve the available captions for.
    /// </summary>
    public required string RecordID { get; set; } = string.Empty;
}
