using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Requests;

public class CreateMeetingRequest
{
    public string Name { get; set; }
    public string MeetingID { get; set; }
    public string AttendeePW { get; set; }
    public string ModeratorPW { get; set; }
    public string Welcome { get; set; }
    public string DialNumber { get; set; }
    public string VoiceBridge { get; set; }
    public int? MaxParticipants { get; set; }
    public string LogoutURL { get; set; }
    public bool? Record { get; set; }
    public int? Duration { get; set; }
    public bool? IsBreakout { get; set; }
    public string ParentMeetingID { get; set; }
    public int? Sequence { get; set; }
    public Metadata Meta { get; set; }
    public bool? FreeJoin { get; set; }
    public bool? BreakoutRoomsEnabled { get; set; }
    public bool? BreakoutRoomsPrivateChatEnabled { get; set; }
    public bool? BreakoutRoomsRecord { get; set; }
    public string ModeratorOnlyMessage { get; set; }
    public bool? AutoStartRecording { get; set; }
    public bool? AllowStartStopRecording { get; set; }
    public bool? WebcamsOnlyForModerator { get; set; }
    public bool? LockSettingsHideViewersCursor { get; set; }
    public string Logo { get; set; }
    public string BannerText { get; set; }
    public string BannerColor { get; set; }
    public string Copyright { get; set; }
    public bool? MuteOnStart { get; set; }
    public bool? AllowModsToUnmuteUsers { get; set; }
    public bool? MeetingKeepEvents { get; set; }
    public bool? EndWhenNoModerator { get; set; }
    public bool? LockSettingsDisableCam { get; set; }
    public bool? LockSettingsDisableMic { get; set; }
    public bool? LockSettingsDisablePrivateChat { get; set; }
    public bool? LockSettingsDisablePublicChat { get; set; }
    public bool? LockSettingsDisableNote { get; set; }
    public bool? LockSettingsLockedLayout { get; set; }
    public bool? LockSettingsLockOnJoin { get; set; }
    public bool? LockSettingsLockOnJoinConfigurable { get; set; }
    public string GuestPolicy { get; set; }
    public int? EndWhenNoModeratorDelayInMinutes { get; set; }

    //FIXME: MeetingLayout is ENUM
    public string MeetingLayout { get; set; }
    public bool? LearningDashboardEnabled { get; set; }
    public int? LearningDashboardCleanupDelayInMinutes { get; set; }
    public bool? AllowModsToEjectCameras { get; set; }
    public bool? AllowRequestsWithoutSession { get; set; }
    public bool? VirtualBackgroundsDisabled { get; set; }
    public int? UserCameraCap { get; set; }
    public int? MeetingCameraCap { get; set; }
    public int? MeetingExpireIfNoUserJoinedInMinutes { get; set; }
    public int? MeetingExpireWhenLastUserLeftInMinutes { get; set; }

    //FIXME: Expected value: Json with Array of groups.
    public string Groups { get; set; }
    public string DisabledFeatures { get; set; }
    public string DisabledFeaturesExclude { get; set; }
    public bool? PreUploadedPresentationOverrideDefault { get; set; }
    public bool? NotifyRecordingIsOn { get; set; }
    public string PresentationUploadExternalUrl { get; set; }
    public string PresentationUploadExternalDescription { get; set; }
    public bool? RecordFullDurationMedia { get; set; }
    public string PreUploadedPresentation { get; set; }
    public string PreUploadedPresentationName { get; set; }
}
