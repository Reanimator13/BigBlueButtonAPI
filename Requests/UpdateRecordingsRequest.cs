﻿namespace BigBlueButton.Requests
{
    public class UpdateRecordingsRequest
    {
        /// <summary>
        /// A record ID for specify the recordings to apply the publish action. It can be a set of record IDs separated by commas.
        /// </summary>
        public string RecordID { get; set; }

        public string Meta { get; set; }
    }
}