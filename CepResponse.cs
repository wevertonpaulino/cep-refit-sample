using Newtonsoft.Json;

namespace CepRefitSample
{
    public class CepResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("district")]
        public string District { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
