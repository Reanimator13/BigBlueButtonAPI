﻿using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigBlueButtonAPI.Utils;

public class QueryStringBuilder : Dictionary<string, string>
{
    public QueryStringBuilder(IDictionary<string, string> dictionary)
        : base(dictionary) { }

    public override string ToString()
    {
        var array = this.Where(p => p.Value != null)
            .Select(p =>
            {
                var key = HttpUtility.UrlEncode(p.Key);
                var value = HttpUtility.UrlEncode(p.Value);

                return key + "=" + value;
            })
            .ToArray();

        return string.Join("&", array);
    }
}
