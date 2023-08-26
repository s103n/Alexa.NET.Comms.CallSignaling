using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Comms.CallSignaling.Enums;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallUpdateRequest : BaseSdpDetailsRequest
    {
        /// <summary>
        /// Type of renegotiation. The acceptable values are CALL_HOLD, CALL_RESUME, CALL_UPDATE.
        /// </summary>
        [JsonProperty("renegotiationType"), JsonConverter(typeof(StringEnumConverter))]
        public RenegotiationType RenegotiationType { get; set; }
    }
    
    public class CallUpdateRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallUpdate";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallUpdateRequest();
        }
    }
}