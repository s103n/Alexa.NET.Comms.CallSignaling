using System.Runtime.Serialization;

namespace Alexa.NET.Comms.CallSignaling.Enums
{
    public enum ParticipantIdType
    {
        [EnumMember(Value = "COMMUNICATION_PROFILE_ID")]
        CommunicationProfileId,
        [EnumMember(Value = "PHONE_NUMBER")]
        PhoneNumber,
        [EnumMember(Value = "RAW_ADDRESS")]
        RawAddress
    }
}