using Newtonsoft.Json;

namespace AtolOnline.V5.Entities
{
    public class Receipt
    {
        [JsonProperty("client")]
        public Client Client { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }
    }
}
