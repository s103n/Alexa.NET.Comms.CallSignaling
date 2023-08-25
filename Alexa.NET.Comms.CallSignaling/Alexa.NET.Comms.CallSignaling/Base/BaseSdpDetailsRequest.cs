using Newtonsoft.Json;

namespace Alexa.NET.Comms.CallSignaling.Base
{
    public class BaseSdpDetailsRequest : BaseSessionRequest
    {
        [JsonProperty("sdpDetails")]
        public SdpDetails SdpDetails { get; set; }
    }
}