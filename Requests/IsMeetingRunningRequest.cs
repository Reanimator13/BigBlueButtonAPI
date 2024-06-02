namespace BigBlueButtonAPI.Requests
{
    public class IsMeetingRunningRequest
    {
        /// <summary>
        /// This call enables you to simply check on whether or not a meeting is running by looking it up with your meeting ID.
        /// </summary>
        public string MeetingID { get; set; }
    }
}
