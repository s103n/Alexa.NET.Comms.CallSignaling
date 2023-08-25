using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallRingingAckRequest : BaseSessionRequest
    {
    }
    
    public class CallRingingAckTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallRingingAck";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallRingingAckRequest();
        }
    }
}