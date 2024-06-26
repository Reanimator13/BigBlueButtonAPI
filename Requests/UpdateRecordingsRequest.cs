﻿using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Requests
{
    public class UpdateRecordingsRequest
    {
        /// <summary>
        /// [Required] A record ID for specify the recordings to apply the publish action. It can be a set of record IDs separated by commas.
        /// </summary>
        public required string RecordID { get; set; } = string.Empty;

        public Metadata? Meta { get; set; }
    }
}
