using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Requests
{
    public class GetRecordingsRequest
    {
        /// <summary>
        /// A meeting ID for get the recordings. It can be a set of meetingIDs separate by commas. If the meeting ID is not specified, it will get ALL the recordings. If a recordID is specified, the meetingID is ignored.
        /// </summary>
        public string MeetingID { get; set; }

        /// <summary>
        /// A record ID for get the recordings. It can be a set of recordIDs separate by commas. If the record ID is not specified, it will use meeting ID as the main criteria. If neither the meeting ID is specified, it will get ALL the recordings. The recordID can also be used as a wildcard by including only the first characters in the string.
        /// </summary>
        public string RecordID { get; set; }

        /// <summary>
        /// Since version 1.0 the recording has an attribute that shows a state that Indicates if the recording is [processing|processed|published|unpublished|deleted]. The parameter state can be used to filter results. It can be a set of states separate by commas. If it is not specified only the states [published|unpublished] are considered (same as in previous versions). If it is specified as “any”, recordings in all states are included.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// You can pass one or more metadata values to filter the recordings returned.
        /// </summary>
        public MetaData Meta { get; set; }

        /// <summary>
        /// The starting index for returned recordings. Number must greater than or equal to 0.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// The maximum number of recordings to be returned. Number must be between 1 and 100.
        /// </summary>
        public int Limit { get; set; }
    }
}
