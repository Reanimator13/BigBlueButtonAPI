using System.Threading;
using System.Threading.Tasks;
using BigBlueButtonAPI.Requests;
using BigBlueButtonAPI.Responses;

namespace BigBlueButtonAPI;

public interface IAPI
{
    Task<BaseResponse> GetVersionAsync(CancellationToken cancellationToken);

    Task<T> CreateMeetingAsync<T>(CreateMeetingRequest request, CancellationToken cancellationToken)
        where T : BaseResponse;

    Task<T> JoinMeetingAsync<T>(JoinMeetingRequest request, CancellationToken cancellationToken)
        where T : BaseResponse;

    Task<T> EndMeetingAsync<T>(EndMeetingRequest request, CancellationToken cancellationToken)
        where T : BaseResponse;

    Task<T> GetMeetingsAsync<T>(CancellationToken cancellationToken)
        where T : BaseResponse;

    Task<T> IsMeetingRunningAsync<T>(
        IsMeetingRunningRequest request,
        CancellationToken cancellationToken
    )
        where T : BaseResponse;

    Task<T> GetMeetingInfoAsync<T>(
        GetMeetingInfoRequest request,
        CancellationToken cancellationToken
    )
        where T : BaseResponse;

    Task<T> GetRecordingsAsync<T>(GetRecordingsRequest request, CancellationToken cancellationToken)
        where T : BaseResponse;

    Task<T> PublishRecordingsAsync<T>(
        PublishRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : BaseResponse;

    Task<T> DeleteRecordingsAsync<T>(
        DeleteRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : BaseResponse;

    Task<T> UpdateRecordingsAsync<T>(
        UpdateRecordingsRequest request,
        CancellationToken cancellationToken
    )
        where T : BaseResponse;

    Task<T> GetRecordingTextTracksAsync<T>(
        GetRecordingTextTracksRequest request,
        CancellationToken cancellationToken
    )
        where T : BaseResponse;
}
