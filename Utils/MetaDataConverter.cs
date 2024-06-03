using BigBlueButtonAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace BigBlueButtonAPI.Utils;

public static class MetaDataConverter
{
    public static string ConvertMetaDataToString(Metadata metaData)
    {
        var metaDataItems = GetMetaDataItems(metaData);

        if (metaDataItems.Any())
        {
            var formUrlEncodedContent = new FormUrlEncodedContent(metaDataItems);
            return formUrlEncodedContent.ReadAsStringAsync().Result;
        }

        return string.Empty;
    }

    private static List<KeyValuePair<string, string>> GetMetaDataItems(Metadata metaData)
    {
        var metaDataItems = new List<KeyValuePair<string, string>>();

        foreach (var key in metaData.Keys)
        {
            metaDataItems.Add(new KeyValuePair<string, string>("meta_" + key, metaData[key]));
        }

        return metaDataItems;
    }
}
