using System.Collections.Generic;
using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class InitiateInboundCallRequest : BaseSdpDetailsRequest
    {
        public class CustomParameters
        {
            [JsonProperty("callerName")]
            public string CallerName { get; set; }
        }
        
        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }
        
        [JsonProperty("customParams")]
        public CustomParameters CustomParams { get; set; }
    }
    
    public class InitiateInboundCallRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.InitiateInboundCall";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new InitiateInboundCallRequest();
        }
    }
}