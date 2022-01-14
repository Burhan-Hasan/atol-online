using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtolOnline.V5.Entities
{
    public class Receipt
    {
        [JsonProperty("client")]
        public Client Client { get; set; }
    }
}
