using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallAcceptedRequest : BaseSdpDetailsRequest
    {
    }
    
    public class CallAcceptedRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallAccepted";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallAcceptedRequest();
        }
    }
}