﻿using System.Collections.Generic;
using System.Net.Http;
using BigBlueButtonAPI.Entities;

namespace BigBlueButtonAPI.Utils;

public static class MetaDataConverter
{
    public static string ConvertMetaDataToString(Metadata metadata)
    {
        var metadataItems = GetMetaDataItems(metadata);

        if (metadataItems.Count != 0)
        {
            var formUrlEncodedContent = new FormUrlEncodedContent(metadataItems);
            return formUrlEncodedContent.ReadAsStringAsync().Result;
        }

        return string.Empty;
    }

    private static List<KeyValuePair<string, string>> GetMetaDataItems(Metadata metadata)
    {
        var metadataItems = new List<KeyValuePair<string, string>>();

        foreach (var key in metadata.Keys)
        {
            metadataItems.Add(new KeyValuePair<string, string>("meta_" + key, metadata[key]));
        }

        return metadataItems;
    }
}
