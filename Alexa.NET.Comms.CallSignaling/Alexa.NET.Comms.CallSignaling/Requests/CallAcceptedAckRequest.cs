using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallAcceptedAckRequest : BaseSessionRequest
    {
    }
    
    public class CallAcceptedAckRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallAcceptedAck";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallAcceptedAckRequest();
        }
    }
}