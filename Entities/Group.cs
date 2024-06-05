using System.Collections.Generic;

namespace BigBlueButtonAPI.Entities
{
    public class Group
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = "";
        public List<string> Roster { get; set; } = new List<string>();
    }
}
