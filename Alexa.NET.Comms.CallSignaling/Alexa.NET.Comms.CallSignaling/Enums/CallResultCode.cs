using System.Runtime.Serialization;

namespace Alexa.NET.Comms.CallSignaling.Enums
{
    public enum CallResultCode
    {
        [EnumMember(Value = "INTERNAL_ERROR")]
        InternalError,
        [EnumMember(Value = "UNAUTHORIZED")]
        Unauthorized,
        [EnumMember(Value = "DEVICE_BUSY")]
        DeviceBusy,
        [EnumMember(Value = "SESSION_TIMEOUT")]
        SessionTimeout,
        [EnumMember(Value = "SUCCESS")]
        Success
    }
}