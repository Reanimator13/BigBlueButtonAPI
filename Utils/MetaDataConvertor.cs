using System.Collections.Generic;
using System.Net.Http;
using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Utils
{
    public static class MetaDataConvertor
    {
        public static string MetaDataToString(MetaData metaData)
        {
            var metaDataItems = new List<KeyValuePair<string, string>>();
            if (metaData.Count > 0)
            {
                foreach (var key in metaData.Keys)
                {
                    metaDataItems.Add(
                        new KeyValuePair<string, string>("meta_" + key, metaData[key])
                    );
                }
            }

            if (metaDataItems.Count > 0)
            {
                var convertor = new FormUrlEncodedContent(metaDataItems);
                return convertor.ReadAsStringAsync().Result;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
