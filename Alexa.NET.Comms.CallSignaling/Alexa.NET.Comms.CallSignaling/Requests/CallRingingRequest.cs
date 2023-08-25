using Alexa.NET.Comms.CallSignaling.Base;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling.Requests
{
    public class CallRingingRequest : BaseSessionRequest
    {
    }
    
    public class CallRingingRequestTypeConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Comms.CallSignaling.CallRinging";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new CallRingingRequest();
        }
    }
}