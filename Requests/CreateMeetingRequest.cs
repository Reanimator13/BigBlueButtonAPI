using System.Collections.Generic;
using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Requests;

public class CreateMeetingRequest
{
    /// <summary>
    /// [Required] A name for the meeting.
    /// </summary>
    public required string Name { get; set; } = string.Empty;

    /// <summary>
    /// [Required] The meeting ID.
    /// </summary>
    public required string MeetingID { get; set; } = string.Empty;

    /// <summary>
    ///[DEPRECATED] The password that the join URL can later provide as its password parameter to indicate the user will join as a viewer.
    /// </summary>
    public string? AttendeePW { get; set; }

    /// <summary>
    /// [DEPRECATED] The password that the join URL can later provide as its password parameter to indicate the user will join as a moderator.
    /// </summary>
    public string? ModeratorPW { get; set; }

    /// <summary>
    /// [Optional] A welcome message that gets displayed on the chat window when the participant joins.
    /// </summary>
    public string? Welcome { get; set; }

    /// <summary>
    /// [Optional] The dial access number that participants can call in using regular phone.
    /// </summary>
    public string? DialNumber { get; set; }

    /// <summary>
    /// [Optional] Voice conference number for the FreeSWITCH voice conference associated with this meeting. This must be a 5-digit number in the range 10000 to 99999.
    /// </summary>
    public string? VoiceBridge { get; set; }

    /// <summary>
    /// [Optional] The maximum number of participants allowed in the meeting.
    /// </summary>
    public int? MaxParticipants { get; set; }

    /// <summary>
    /// [Optional] The URL to which participants will be redirected after logging out.
    /// </summary>
    public string? LogoutURL { get; set; }

    /// <summary>
    /// [Optional] Whether to record the meeting.
    /// </summary>
    public bool? Record { get; set; } = false;

    /// <summary>
    /// [Optional] The duration of the meeting in minutes.
    /// </summary>
    public int? Duration { get; set; }

    /// <summary>
    /// [Optional] Must be set to true to create a breakout room.
    /// </summary>
    public bool? IsBreakout { get; set; }

    /// <summary>
    /// [Optional] The parent meeting ID.
    /// </summary>
    public string? ParentMeetingID { get; set; }

    /// <summary>
    /// [Optional] The meeting sequence number.
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// [Optional] If set to true, the client will give the user the choice to choose the breakout rooms he wants to join.
    /// </summary>
    public bool? FreeJoin { get; set; }

    /// <summary>
    /// [DEPRECATED] [Removed in 2.5] If set to false, breakout rooms will be disabled.
    /// </summary>
    public bool? BreakoutRoomsEnabled { get; set; } = true;

    /// <summary>
    /// [Optional] If set to false, breakout rooms will be private.
    /// </summary>
    public bool? BreakoutRoomsPrivateChatEnabled { get; set; } = true;

    /// <summary>
    /// [Optional] If set to false, breakout rooms will be recordable.
    /// </summary>
    public bool? BreakoutRoomsRecord { get; set; } = true;

    /// <summary>
    /// [Optional] Metadata
    /// </summary>
    public Metadata? Meta { get; set; }

    /// <summary>
    /// [Optional] Display a message to all moderators in the public chat.
    /// </summary>
    public string? ModeratorOnlyMessage { get; set; }

    /// <summary>
    /// [Optional] Whether to auto start recording.
    /// </summary>
    public bool? AutoStartRecording { get; set; } = false;
    public bool? AllowStartStopRecording { get; set; }
    public bool? WebcamsOnlyForModerator { get; set; }
    public bool? LockSettingsHideViewersCursor { get; set; }
    public string? Logo { get; set; }
    public string? BannerText { get; set; }
    public string? BannerColor { get; set; }
    public string? Copyright { get; set; }
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
    public string? GuestPolicy { get; set; }
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
    public List<Group>? Groups { get; set; }
    public string? DisabledFeatures { get; set; }
    public string? DisabledFeaturesExclude { get; set; }
    public bool? PreUploadedPresentationOverrideDefault { get; set; }
    public bool? NotifyRecordingIsOn { get; set; }
    public string? PresentationUploadExternalUrl { get; set; }
    public string? PresentationUploadExternalDescription { get; set; }
    public bool? RecordFullDurationMedia { get; set; }
    public string? PreUploadedPresentation { get; set; }
    public string? PreUploadedPresentationName { get; set; }
}
