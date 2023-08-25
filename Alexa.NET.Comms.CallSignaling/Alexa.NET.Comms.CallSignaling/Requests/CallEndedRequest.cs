using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallEndedRequest : BaseSessionRequest
    {
        [JsonProperty("callResult")]
        public CallResult CallResult { get; set; }
    }
    
    public class CallEndedRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallEnded";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallEndedRequest();
        }
    }
}