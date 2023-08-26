using Alexa.NET.Comms.CallSignaling.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Comms.CallSignaling.Base
{
    public class CallResult
    {
        /// <summary>
        /// Status of the call result. Possible values are: INTERNAL_ERROR, UNAUTHORISED, DEVICE_BUSY, SESSION_TIMEOUT, SUCCESS.
        /// </summary>
        [JsonProperty("code"), JsonConverter(typeof(StringEnumConverter))]
        public CallResultCode Code { get; set; }

        /// <summary>
        /// Detailed description why the call has ended.
        /// </summary>
        public string Message { get; set; }
    }
}