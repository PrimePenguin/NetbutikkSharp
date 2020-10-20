using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _NettbutikkSharp.Entities
{
    public class OrderUpdateStatusRequest
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class LineItemUpdateRequest
    {
        [JsonProperty("sent")]
        public string Sent { get; set; }

        [JsonProperty("sent_date")]
        public string SentDate { get; set; }

        [JsonProperty("extra_field")]
        public string ExtraField { get; set; }
    }
}
