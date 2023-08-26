using Alexa.NET.Comms.CallSignaling.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Comms.CallSignaling.Base
{
    public class Participant
    {
        public class TypeValue
        {
            /// <summary>
            /// Type of supported participant ID. Possible values: COMMUNICATION_PROFILE_ID, PHONE_NUMBER, RAW_ADDRESS. RAW_ADDRESS means the address is used as is.
            /// </summary>
            [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
            public ParticipantIdType Type { get; set; }
            
            /// <summary>
            /// Participant identifier value. This value can be a phone number, raw address value, or communication profile ID. Raw address value is used as is.
            /// </summary>
            [JsonProperty("value")] 
            public string Value { get; set; }
        }
        
        /// <summary>
        /// Participant identifier details.
        /// </summary>
        [JsonProperty("id")]
        public TypeValue Id { get; set; }
        
        /// <summary>
        /// Whether participant is the originator of the call. If not set, the default is false. when set to true, the participant is the caller.
        /// </summary>
        [JsonProperty("isOriginator")]
        public bool IsOriginator { get; set; }
    }
}