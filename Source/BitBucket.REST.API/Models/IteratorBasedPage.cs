﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace BitBucket.REST.API.Models
{
    public class IteratorBasedPage<T>
    {
        [JsonProperty(PropertyName = "page_len")]
        public int? PageLen { get; set; }

        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

        [JsonProperty(PropertyName = "values")]
        public List<T> Values { get; set; }

        [JsonProperty(PropertyName = "size")]
        public ulong? Size { get; set; }
    }
}