namespace BigBlueButtonAPI.Requests
{
    /// <summary>
    /// Get the details of a Meeting.
    /// </summary>
    public class GetMeetingInfoRequest
    {
        /// <summary>
        /// [Required] The meeting ID that identifies the meeting you are attempting to check on.
        /// </summary>
        public required string MeetingID { get; set; } = string.Empty;
    }
}
