using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Comms.CallSignaling.Enums;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Comms.CallSignaling.Responses
{
    public class CallUpdateResponse : BaseSdpDetailsRequest
    {
        [JsonProperty("renegotiationType"), JsonConverter(typeof(StringEnumConverter))]
        public RenegotiationType RenegotiationType { get; set; }
    }
    
    public class CallUpdateResponseTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallUpdateResponse";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallUpdateResponse();
        }
    }
}