using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallUpdateAckRequest : BaseSessionRequest
    {
    }
    
    public class CallUpdateAckRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallUpdateAck";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallUpdateAckRequest();
        }
    }
}