using BigBlueButtonAPI.Requests;
using BigBlueButtonAPI.Responses;
using BigBlueButtonAPI.Utils;
using BigBlueButtonAPI.Requests;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BigBlueButtonAPI;

public class API : IAPI
{
    private readonly string _url;
    private readonly string _secretKey;

    #region Constructor
    public API(string url, string secretKey)
    {
        if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(secretKey))
            throw new ArgumentException("Url and SecretKey cannot be null or whitespace.");

        _url = url.EndsWith("/") ? url : url + "/";
        _secretKey = secretKey;
    }
    #endregion

    #region Version
    /// <summary>
    /// Gets the version of the BigBlueButton API.
    /// </summary>
    /// <returns></returns>
    public async Task<BaseResponse> GetVersionAsync()
    {
        return BaseResponseParser.Parse<BaseResponse>(await HttpGetAsync(_url));
    }

    #endregion

    #region Administration

    #region CreateMeeting

    public async Task<T> CreateMeetingAsync<T>(CreateMeetingRequest request)
        where T : BaseResponse
    {
        if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.MeetingID))
        {
            throw new ArgumentException("Name and MeetingID cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string>
        {
            { "name", request.Name },
            { "meetingID", request.MeetingID },
            { "attendeePW", request.AttendeePW ?? string.Empty },
            { "moderatorPW", request.ModeratorPW ?? string.Empty },
            { "welcome", request.Welcome ?? string.Empty },
            { "dialNumber", request.DialNumber ?? string.Empty },
            { "voiceBridge", request.VoiceBridge ?? string.Empty },
            { "maxParticipants", request.MaxParticipants.ToString() ?? string.Empty },
            { "logoutURL", request.LogoutURL ?? string.Empty },
            { "record", request.Record.ToString() ?? string.Empty },
            { "duration", request.Duration.ToString() ?? string.Empty },
            { "isBreakout", request.IsBreakout.ToString() ?? string.Empty },
            { "parentMeetingID", request.ParentMeetingID ?? string.Empty },
            { "sequence", request.Sequence.ToString() ?? string.Empty },
            { "freeJoin", request.FreeJoin.ToString() ?? string.Empty },
            { "breakoutRoomsEnabled", request.BreakoutRoomsEnabled.ToString() ?? string.Empty },
            {
                "breakoutRoomsPrivateChatEnabled",
                request.BreakoutRoomsPrivateChatEnabled.ToString() ?? string.Empty
            },
            { "breakoutRoomsRecord", request.BreakoutRoomsRecord.ToString() ?? string.Empty },
            { "meta", request.Meta.ToString() ?? string.Empty },
            { "moderatorOnlyMessage", request.ModeratorOnlyMessage ?? string.Empty },
            { "autoStartRecording", request.AutoStartRecording.ToString() ?? string.Empty },
            {
                "allowStartStopRecording",
                request.AllowStartStopRecording.ToString() ?? string.Empty
            },
            {
                "webcamsOnlyForModerator",
                request.WebcamsOnlyForModerator.ToString() ?? string.Empty
            },
            { "bannerText", request.BannerText ?? string.Empty },
            { "bannerColor", request.BannerColor ?? string.Empty },
            { "muteOnStart", request.MuteOnStart.ToString() ?? string.Empty },
            { "allowModsToUnmuteUsers", request.AllowModsToUnmuteUsers.ToString() ?? string.Empty },
            { "lockSettingsDisableCam", request.LockSettingsDisableCam.ToString() ?? string.Empty },
            { "lockSettingsDisableMic", request.LockSettingsDisableMic.ToString() ?? string.Empty },
            {
                "lockSettingsDisablePrivateChat",
                request.LockSettingsDisablePrivateChat.ToString() ?? string.Empty
            },
            {
                "lockSettingsDisablePublicChat",
                request.LockSettingsDisablePublicChat.ToString() ?? string.Empty
            },
            {
                "lockSettingsDisableNote",
                request.LockSettingsDisableNote.ToString() ?? string.Empty
            },
            {
                "lockSettingsDisablePrivateChat",
                request.LockSettingsDisablePrivateChat.ToString() ?? string.Empty
            },
            { "lockSettingsLockOnJoin", request.LockSettingsLockOnJoin.ToString() ?? string.Empty },
            {
                "lockSettingsLockOnJoinConfigurable",
                request.LockSettingsLockOnJoinConfigurable.ToString() ?? string.Empty
            },
            {
                "lockSettingsHideViewersCursor",
                request.LockSettingsHideViewersCursor.ToString() ?? string.Empty
            },
            { "guestPolicy", request.GuestPolicy.ToString() ?? string.Empty },
            { "meetingKeepEvents", request.MeetingKeepEvents.ToString() ?? string.Empty },
            { "endWhenNoModerator", request.EndWhenNoModerator.ToString() ?? string.Empty },
            {
                "endWhenNoModeratorDelayInMinutes",
                request.EndWhenNoModeratorDelayInMinutes.ToString() ?? string.Empty
            },
            //FIXME: MeetingLayout is ENUM
            { "meetingLayout", request.MeetingLayout.ToString() ?? string.Empty },
            {
                "learningDashboardEnabled",
                request.LearningDashboardEnabled.ToString() ?? string.Empty
            },
            {
                "learningDashboardCleanupDelayInMinutes",
                request.LearningDashboardCleanupDelayInMinutes.ToString() ?? string.Empty
            },
            {
                "allowModsToEjectCameras",
                request.AllowModsToEjectCameras.ToString() ?? string.Empty
            },
            {
                "allowRequestsWithoutSession",
                request.AllowRequestsWithoutSession.ToString() ?? string.Empty
            },
            {
                "virtualBackgroundsDisabled",
                request.VirtualBackgroundsDisabled.ToString() ?? string.Empty
            },
            { "userCameraCap", request.UserCameraCap.ToString() ?? string.Empty },
            { "meetingCameraCap", request.MeetingCameraCap.ToString() ?? string.Empty },
            {
                "meetingExpireIfNoUserJoinedInMinutes",
                request.MeetingExpireIfNoUserJoinedInMinutes.ToString() ?? string.Empty
            },
            {
                "meetingExpireWhenLastUserLeftInMinutes",
                request.MeetingExpireWhenLastUserLeftInMinutes.ToString() ?? string.Empty
            },
            //TODO: Add other parameters
        };

        return await GetResponseAsync<T>("create", parameters);
    }
    #endregion

    #region JoinMeting
    public async Task<T> JoinMeetingAsync<T>(JoinMeetingRequest request)
        where T : BaseResponse
    {
        if (
            string.IsNullOrWhiteSpace(request.FullName)
            || string.IsNullOrWhiteSpace(request.MeetingID)
        )
        {
            throw new ArgumentException("FullName and MeetingID cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string>
        {
            { "fullName", request.FullName },
            { "meetingID", request.MeetingID },
            { "password", request.Password ?? string.Empty },
            { "role", request.Role ?? string.Empty },
            { "createTime", request.CreateTime ?? string.Empty },
            { "userID", request.UserID ?? string.Empty },
            { "webVoiceConf", request.WebVoiceConf ?? string.Empty },
            { "defaultLayout", request.DefaultLayout ?? string.Empty },
            { "avatarURL", request.AvatarURL ?? string.Empty },
            { "redirect", request.Redirect ?? string.Empty },
            { "errorRedirectUrl", request.ErrorRedirectUrl ?? string.Empty },
            { "joinViaHtml5", request.JoinViaHtml5 ?? string.Empty },
            { "guest", request.Guest ?? string.Empty },
            { "excludeFromDashboard", request.ExcludeFromDashboard ?? string.Empty },
        };

        return await GetResponseAsync<T>("join", parameters);
    }
    #endregion

    #region EndMeeting
    public async Task<T> EndMeetingAsync<T>(EndMeetingRequest request)
        where T : BaseResponse
    {
        if (string.IsNullOrWhiteSpace(request.MeetingID))
        {
            throw new ArgumentException("MeetingID cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string>
        {
            { "meetingID", request.MeetingID },
            { "password", request.Password ?? string.Empty }
        };

        return await GetResponseAsync<T>("end", parameters);
    }

    #endregion

    #endregion

    #region Monitoring

    #region isMeetingRunning
    public async Task<T> IsMeetingRunningAsync<T>(IsMeetingRunningRequest request)
        where T : BaseResponse
    {
        if (string.IsNullOrWhiteSpace(request.MeetingID))
        {
            throw new ArgumentException("MeetingID cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string> { { "meetingID", request.MeetingID } };

        return await GetResponseAsync<T>("isMeetingRunning", parameters);
    }
    #endregion

    #region getMeetings
    public async Task<T> GetMeetingsAsync<T>()
        where T : BaseResponse
    {
        return await GetResponseAsync<T>("getMeetings", new Dictionary<string, string>());
    }
    #endregion

    #region getMeetingInfo
    public async Task<T> GetMeetingInfoAsync<T>(GetMeetingInfoRequest request)
        where T : BaseResponse
    {
        if (string.IsNullOrWhiteSpace(request.MeetingID))
        {
            throw new ArgumentException("MeetingId cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string> { { "meetingID", request.MeetingID } };

        return await GetResponseAsync<T>("getMeetingInfo", parameters);
    }
    #endregion

    #endregion

    #region Recording

    #region getRecordings

    public async Task<T> GetRecordingsAsync<T>(GetRecordingsRequest request)
        where T : BaseResponse
    {
        var parameters = new Dictionary<string, string>
        {
            { "meetingID", request.MeetingID ?? string.Empty },
            { "recordID", request.RecordID ?? string.Empty },
            { "state", request.State ?? string.Empty },
            { "meta", request.Meta.ToString() ?? string.Empty },
            { "offset", request.Offset.ToString() ?? string.Empty },
            { "limit", request.Limit.ToString() ?? string.Empty }
        };

        return await GetResponseAsync<T>("getRecordings", parameters);
    }

    #region publishRecordings
    public async Task<T> PublishRecordingsAsync<T>(PublishRecordingsRequest request)
        where T : BaseResponse
    {
        if (
            string.IsNullOrWhiteSpace(request.RecordID)
            || string.IsNullOrWhiteSpace(request.Publish.ToString())
        )
        {
            throw new ArgumentException("RecordID or Publish cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string>
        {
            { "recordID", request.RecordID },
            { "publish", request.Publish.ToString() },
        };

        return await GetResponseAsync<T>("publishRecordings", parameters);
    }
    #endregion
    #endregion

    #region deleteRecordings
    public async Task<T> DeleteRecordingsAsync<T>(DeleteRecordingsRequest request)
        where T : BaseResponse
    {
        if (string.IsNullOrWhiteSpace(request.RecordID))
        {
            throw new ArgumentException("RecordID cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string> { { "recordID", request.RecordID } };

        return await GetResponseAsync<T>("deleteRecordings", parameters);
    }
    #endregion

    #region updateRecordings
    public async Task<T> UpdateRecordingsAsync<T>(UpdateRecordingsRequest request)
        where T : BaseResponse
    {
        if (string.IsNullOrWhiteSpace(request.RecordID))
        {
            throw new ArgumentException("RecordID cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string>
        {
            { "recordID", request.RecordID },
            { "meta", request.Meta.ToString() ?? string.Empty }
        };

        return await GetResponseAsync<T>("updateRecordings", parameters);
    }
    #endregion

    #region getRecordingTextTracks


    public async Task<T> GetRecordingTextTracksAsync<T>(GetRecordingTextTracksRequest request)
        where T : BaseResponse
    {
        if (string.IsNullOrWhiteSpace(request.RecordID))
        {
            throw new ArgumentException("RecordID cannot be null or whitespace.");
        }

        var parameters = new Dictionary<string, string> { { "recordID", request.RecordID } };

        return await GetResponseAsync<T>("getRecordingTextTracks", parameters);
    }
    #endregion

    #endregion

    #region Private Methods
    /// <summary>
    /// Asynchronously sends a GET request to the specified URL and returns the response as a string.
    /// </summary>
    /// <param name="url">The URL to send the GET request to.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response from the server.</returns>
    private static async Task<string> HttpGetAsync(string url)
    {
        // Create an instance of the HttpClient class to send the GET request.
        using var httpClient = new HttpClient();

        // Send a GET request to the specified URL and get the response.
        return await httpClient.GetStringAsync(url);
    }

    /// <summary>
    /// Generates a checksum for the given API call name and parameters using the secret key.
    /// </summary>
    /// <param name="apiCallName">The name of the API call.</param>
    /// <param name="parameters">The parameters for the API call.</param>
    /// <returns>The checksum generated from the API call name, parameters, and secret key.</returns>
    private string GenerateChecksum(string apiCallName, string parameters)
    {
        // Concatenate the API call name, parameters, and secret key to generate the checksum
        string input = apiCallName + parameters + _secretKey;

        // Generate the checksum using the SHA1 hashing algorithm
        string checksum = SHA1.SHA1HashStringForUTF8String(input);

        return checksum;
    }

    /// <summary>
    /// Asynchronously sends a GET request to the BigBlueButton API and parses the response into a specific type.
    /// </summary>
    /// <typeparam name="T">The type of the response to parse.</typeparam>
    /// <param name="apiCallName">The name of the API call.</param>
    /// <param name="parameters">The parameters for the API call.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the parsed response.</returns>
    private async Task<T> GetResponseAsync<T>(
        string apiCallName,
        Dictionary<string, string> parameters
    )
        where T : BaseResponse
    {
        // Build the query string by adding the parameters and the checksum
        var queryBuilder = new QueryStringBuilder(parameters);
        queryBuilder.Add("checksum", GenerateChecksum(apiCallName, queryBuilder.ToString()));

        // Construct the full URL by appending the API call name and the query string
        var fullUrl = $"{_url}{apiCallName}?{queryBuilder}";

        // Send a GET request to the BigBlueButton API and get the response
        var response = await HttpGetAsync(fullUrl);

        // Parse the response into the specified type and return it
        return BaseResponseParser.Parse<T>(response);
    }
    #endregion
}
