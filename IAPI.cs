using System.Threading;
using System.Threading.Tasks;
using BigBlueButtonAPI.Requests;
using BigBlueButtonAPI.Responses;

namespace BigBlueButtonAPI;

public interface IAPI
{
    Task<BaseResponse> GetVersionAsync(CancellationToken cancellationToken);

    Task<T> GET_CreateMeetingAsync<T>(
        CreateMeetingRequest request,
        CancellationToken cancellationToken
    )
        where T : CreateMeetingResponse;

    Task<T> POST_CreateMeetingAsync<T>(
        CreateMeetingRequest request,
        CancellationToken cancellationToken
    )
        where T : CreateMeetingResponse;

    Task<T> GET_JoinMeetingAsync<T>(JoinMeetingRequest request, CancellationToken cancellationToken)
        where T : JoinMeetingResponse;

    Task<T> GET_IsMeetingRunningAsync<T>(
        IsMeetingRunningRequest request,
        CancellationToken cancellationToken
    )
        where T : IsMeetingRunningResponse;

    Task<T> POST_IsMeetingRunningAsync<T>(
        IsMeetingRunningRequest request,
        CancellationToken cancellationToken
    )
        where T : IsMeetingRunningResponse;

    Task<T> GET_EndMeetingAsync<T>(EndMeetingRequest request, CancellationToken cancellationToken)
        where T : EndMeetingResponse;

    Task<T> POST_EndMeetingAsync<T>(EndMeetingRequest request, CancellationToken cancellationToken)
        where T : EndMeetingResponse;

    Task<T> GET_GetMeetingsAsync<T>(CancellationToken cancellationToken)
        where T : GetMeetingsResponse;

    Task<T> POST_GetMeetingsAsync<T>(CancellationToken cancellationToken)
        where T : GetMeetingsResponse;

    Task<T> GET_GetMeetingInfoAsync<T>(
        GetMeetingInfoRequest request,
        CancellationToken cancellationToken
    )
        where T : GetMeetingInfoResponse;

    Task<T> POST_GetMeetingInfoAsync<T>(
        GetMeetingInfoRequest request,
        CancellationToken cancellationToken
    )
        where T : GetMeetingInfoResponse;

    Task<T> GET_GetRecordingsAsync<T>(
        GetRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : GetRecordingsResponse;

    Task<T> GET_PublishRecordingsAsync<T>(
        PublishRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : PublishRecordingsResponse;

    Task<T> GET_DeleteRecordingsAsync<T>(
        DeleteRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : DeleteRecordingsResponse;

    Task<T> GET_UpdateRecordingsAsync<T>(
        UpdateRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : UpdateRecordingsResponse;

    Task<T> POST_UpdateRecordingsAsync<T>(
        UpdateRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : UpdateRecordingsResponse;

    Task<T> GET_GetRecordingTextTracksAsync<T>(
        GetRecordingTextTracksRequest request,
        CancellationToken cancellationToken
    )
        where T : GetRecordingTextTracksResponse;

    Task<T> POST_GetRecordingTextTracksAsync<T>(
        GetRecordingTextTracksRequest request,
        CancellationToken cancellationToken
    )
        where T : GetRecordingTextTracksResponse;
}
