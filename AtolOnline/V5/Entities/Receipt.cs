using Newtonsoft.Json;
using System.Collections.Generic;

namespace AtolOnline.V5.Entities
{
    public class Receipt
    {
        [JsonProperty("client")]
        public Client Client { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
        
        [JsonProperty("vats")]
        public List<Vat> Vats { get; set; }
    }
}
