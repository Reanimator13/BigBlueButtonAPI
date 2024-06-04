namespace BigBlueButtonAPI.Requests
{
    public class DeleteRecordingsRequest
    {
        /// <summary>
        /// A record ID for specify the recordings to delete. It can be a set of record IDs separated by commas.
        /// </summary>
        public string RecordID { get; set; } = string.Empty;
    }
}
