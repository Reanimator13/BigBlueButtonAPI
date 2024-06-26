﻿using BigBlueButtonAPI.Entities;
using BigBlueButtonAPI.Enums;

namespace BigBlueButtonAPI.Requests
{
    /// <summary>
    /// Get a list of recordings. Support for pagination was added in 2.6.
    /// </summary>
    public class GetRecordingsRequest
    {
        /// <summary>
        /// [Optional] A meeting ID for get the recordings.
        /// </summary>
        public string? MeetingID { get; set; }

        /// <summary>
        /// [Optional] A record ID for get the recordings.
        /// </summary>
        public string? RecordID { get; set; }

        /// <summary>
        /// [Optional] Since version 1.0 the recording has an attribute that shows a state that Indicates if the recording is [processing|processed|published|unpublished|deleted]. The parameter state can be used to filter results. It can be a set of states separate by commas. If it is not specified only the states [published|unpublished] are considered (same as in previous versions). If it is specified as “any”, recordings in all states are included.
        /// </summary>
        public State? State { get; set; }

        /// <summary>
        /// You can pass one or more metadata values to filter the recordings returned.
        /// </summary>
        public Metadata? Meta { get; set; }

        /// <summary>
        /// The starting index for returned recordings. Number must greater than or equal to 0.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// The maximum number of recordings to be returned. Number must be between 1 and 100.
        /// </summary>
        public int? Limit { get; set; }
    }
}
