using System.Collections.Generic;

namespace BigBlueButtonAPI.Requests
{
    /// <summary>
    /// Deletes an existing Recording.
    /// </summary>
    public class DeleteRecordingsRequest
    {
        /// <summary>
        /// [Required] A record ID for specify the recordings to delete. It can be a set of record IDs separated by commas.
        /// </summary>
        public required List<string> RecordID { get; set; } = [];
    }
}
