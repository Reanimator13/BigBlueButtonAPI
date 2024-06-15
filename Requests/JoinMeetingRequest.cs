using BigBlueButtonAPI.Enums;

namespace BigBlueButtonAPI.Requests;

public class JoinMeetingRequest
{
    public string FullName { get; set; }
    public string MeetingID { get; set; }
    public string Password { get; set; }
    public required Role Role { get; set; }
    public string CreateTime { get; set; }
    public string UserID { get; set; }
    public string WebVoiceConf { get; set; }
    public string DefaultLayout { get; set; }
    public string AvatarURL { get; set; }
    public string Redirect { get; set; }
    public string ErrorRedirectUrl { get; set; }
    public string JoinViaHtml5 { get; set; }
    public string Guest { get; set; }
    public string ExcludeFromDashboard { get; set; }
}
