using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Requests;

public class CreateMeetingRequest
{
    /// <summary>
    /// A name for the meeting. This is now required as of BigBlueButton 2.4.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A meeting ID that can be used to identify this meeting by the 3rd-party application.
    /// </summary>
    public string MeetingID { get; set; }

    /// <summary>
    /// [DEPRECATED] The password that the join URL can later provide as its password parameter to indicate the user will join as a viewer.
    /// If no attendeePW is provided,
    /// the create call will return a randomly generated attendeePW password for the meeting.
    /// </summary>
    public string AttendeePW { get; set; }

    /// <summary>
    /// [DEPRECATED] The password that will join URL can later provide as its password parameter to indicate the user will as a moderator.
    /// If no moderatorPW is provided, create will return a randomly generated moderatorPW password for the meeting.
    /// </summary>
    public string ModeratorPW { get; set; }

    /// <summary>
    /// A welcome message that gets displayed on the chat window when the participant joins.
    /// </summary>
    public string Welcome { get; set; }

    /// <summary>
    /// The dial access number that participants can call in using regular phone.
    /// </summary>
    public string DialNumber { get; set; }

    /// <summary>
    /// Voice conference number for the FreeSWITCH voice conference associated with this meeting. This must be a 5-digit number in the range 10000 to 99999.
    /// </summary>
    public string VoiceBridge { get; set; }

    /// <summary>
    /// Set the maximum number of users allowed to joined the conference at the same time.
    /// </summary>
    public int? MaxParticipants { get; set; }

    /// <summary>
    /// The URL that the BigBlueButton client will go to after users click the OK button on the ‘You have been logged out message’.
    /// </summary>
    public string LogoutURL { get; set; }

    /// <summary>
    /// Setting ‘record=true’ instructs the BigBlueButton server to record the media and events in the session for later playback. The default is false.
    /// </summary>
    public bool? Record { get; set; } = false;
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
    public bool? KeepEvents { get; set; }
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
    public MeetingLayout MeetingLayout { get; set; } = MeetingLayout.SMART_LAYOUT;
    public bool? LearningDashboardEnabled { get; set; }
    public int? LearningDashboardCleanupDelayInMinutes { get; set; }
    public bool? AllowModsToEjectCameras { get; set; }
    public bool? AllowRequestsWithoutSession { get; set; }
    public bool? VirtualBackgroundsDisabled { get; set; }
    public int? UserCameraCap { get; set; } = 3;
    public int? MeetingCameraCap { get; set; }
    public int? MeetingExpireIfNoUserJoinedInMinutes { get; set; }
    public int? MeetingExpireWhenLastUserLeftInMinutes { get; set; }

    //FIX: Expected value: Json with Array of groups.
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
