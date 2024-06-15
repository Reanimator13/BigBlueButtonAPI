using System.Collections.Generic;

namespace BigBlueButtonAPI.Entities
{
    public class Group
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public List<string> Roster { get; set; } = [];
    }
}
