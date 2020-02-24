﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Script Tags.
    /// </summary>
    public class ScriptTagListFilter : ListFilter<ScriptTag>
    {
        /// <summary>
        /// Returns only those with the given src value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}
