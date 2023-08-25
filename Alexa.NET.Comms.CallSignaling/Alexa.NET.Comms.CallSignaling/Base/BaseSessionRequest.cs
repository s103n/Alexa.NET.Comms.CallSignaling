using Newtonsoft.Json;

namespace Alexa.NET.Comms.CallSignaling.Base
{
    public class BaseSessionRequest : Request.Type.Request
    {
        [JsonProperty("sessionId")] 
        public string SessionId { get; set; }
    }
}