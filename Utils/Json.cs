using System.Collections.Generic;
using BigBlueButtonAPI.Entities;
using Newtonsoft.Json;

namespace BigBlueButtonAPI.Utils
{
    internal class Json
    {
        public static string GroupsToJsonString(List<Group> groups)
        {
            if (groups == null)
                return string.Empty;

            return JsonConvert.SerializeObject(groups);
        }
    }
}
