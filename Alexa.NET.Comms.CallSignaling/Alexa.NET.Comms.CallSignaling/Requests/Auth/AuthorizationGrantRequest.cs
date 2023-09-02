using Alexa.NET.Request.Type;
using Newtonsoft.Json;

namespace Alexa.NET.Comms.CallSignaling.Requests.Auth
{
    public class AuthorizationGrantRequest : Request.Type.Request
    {
        public class AuthorizationGrantBody
        {
            [JsonProperty("grant")]
            public AuthorizationGrant Grant { get; set; }
            
            public class AuthorizationGrant
            {
                [JsonProperty("type")]
                public string Type { get; set; }
                
                [JsonProperty("code")]
                public string Code { get; set; }
            }
        }
        
        [JsonProperty("body")]
        public AuthorizationGrantBody Body { get; set; }
    }
    
    public class AuthorizationGrantRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Authorization.Grant";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new AuthorizationGrantRequest();
        }
    }
}