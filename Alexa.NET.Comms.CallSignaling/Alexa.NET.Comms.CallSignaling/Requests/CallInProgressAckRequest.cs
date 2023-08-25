using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallInProgressAckRequest : BaseSessionRequest
    {
    }
    
    public class CallInProgressAckTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallInProgressAck";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallInProgressAckRequest();
        }
    }
}