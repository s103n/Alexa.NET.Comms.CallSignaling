using Newtonsoft.Json;

namespace Alexa.NET.Comms.CallSignaling.Base
{
    public class SdpDetails
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}