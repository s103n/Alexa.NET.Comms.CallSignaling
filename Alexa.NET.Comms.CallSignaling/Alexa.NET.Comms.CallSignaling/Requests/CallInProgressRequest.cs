using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallInProgressRequest : BaseSdpDetailsRequest
    {
    }
    
    public class CallInProgressRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallInProgress";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallInProgressRequest();
        }
    }
}