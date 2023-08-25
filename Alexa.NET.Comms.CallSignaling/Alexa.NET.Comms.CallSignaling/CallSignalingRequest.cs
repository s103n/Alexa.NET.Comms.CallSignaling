using System.Collections.Generic;
using Alexa.NET.Comms.CallSignaling.Requests;
using Alexa.NET.Comms.CallSignaling.Responses;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Comms.CallSignaling
{
    public static class CallSignalingRequests
    {
        public static void AddToRequestConverter()
        {
            RequestConverter.RequestConverters.AddRange(new List<IRequestTypeConverter>
            {
                new CallAcceptedAckRequestTypeConverter(),
                new CallAcceptedRequestTypeConverter(),
                new CallEndedRequestTypeConverter(),
                new CallInProgressRequestTypeConverter(),
                new CallInProgressAckTypeConverter(),
                new CallRingingRequestTypeConverter(),
                new CallRingingAckTypeConverter(),
                new CallUpdateRequestTypeConverter(),
                new CallUpdateAckRequestTypeConverter(),
                new InitiateInboundCallRequestTypeConverter(),
                new CallUpdateResponseTypeConverter()
            });
        }
    }
}