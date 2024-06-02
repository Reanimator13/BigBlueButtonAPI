using BigBlueButtonAPI.Requests;
using BigBlueButtonAPI.Responses;
using System.Threading.Tasks;

namespace BigBlueButtonAPI;

public interface IAPI
{
    Task<BaseResponse> GetVersionAsync();

    Task<T> CreateMeetingAsync<T>(CreateMeetingRequest request)
        where T : BaseResponse;

    Task<T> JoinMeetingAsync<T>(JoinMeetingRequest request)
        where T : BaseResponse;

    Task<T> EndMeetingAsync<T>(EndMeetingRequest request)
        where T : BaseResponse;

    Task<T> GetMeetingsAsync<T>()
        where T : BaseResponse;

    Task<T> IsMeetingRunningAsync<T>(IsMeetingRunningRequest request)
        where T : BaseResponse;

    Task<T> GetMeetingInfoAsync<T>(GetMeetingInfoRequest request)
        where T : BaseResponse;

    Task<T> GetRecordingsAsync<T>(GetRecordingsRequest request)
        where T : BaseResponse;

    Task<T> PublishRecordingsAsync<T>(PublishRecordingsRequest request)
        where T : BaseResponse;

    Task<T> DeleteRecordingsAsync<T>(DeleteRecordingsRequest request)
        where T : BaseResponse;

    Task<T> UpdateRecordingsAsync<T>(UpdateRecordingsRequest request)
        where T : BaseResponse;

    Task<T> GetRecordingTextTracksAsync<T>(GetRecordingTextTracksRequest request)
        where T : BaseResponse;
}
