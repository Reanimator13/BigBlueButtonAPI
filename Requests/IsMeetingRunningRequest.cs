namespace BigBlueButtonAPI.Requests
{
    /// <summary>
    /// Checks whether if a specified meeting is running.
    /// </summary>
    public class IsMeetingRunningRequest
    {
        /// <summary>
        /// [Required] The meeting ID that identifies the meeting you are attempting to check on.
        /// </summary>
        public required string MeetingID { get; set; } = string.Empty;
    }
}
