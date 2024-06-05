namespace BigBlueButtonAPI.Requests;

public class EndMeetingRequest
{
    /// <summary>
    /// The meeting ID that identifies the meeting you are attempting to end.
    /// </summary>
    public string MeetingID { get; set; } = string.Empty;

    /// <summary>
    /// [DEPRECATED] The moderator password for this meeting. You can not end a meeting using the attendee password.
    /// </summary>
    public string Password { get; set; } = string.Empty;
}
