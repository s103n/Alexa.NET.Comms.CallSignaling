using System.Runtime.Serialization;

namespace Alexa.NET.Comms.CallSignaling.Enums
{
    public enum RenegotiationType
    {
        [EnumMember(Value = "CALL_HOLD")]
        CallHold,
        [EnumMember(Value = "CALL_RESUME")]
        CallResume,
        [EnumMember(Value = "CALL_UPDATE")]
        CallUpdate
    }
}