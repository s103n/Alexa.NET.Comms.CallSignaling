namespace Alexa.NET.Comms.CallSignaling.Base
{
    public class CallResult
    {
        /// <summary>
        /// Status of the call result. Possible values are: INTERNAL_ERROR, UNAUTHORISED, DEVICE_BUSY, SESSION_TIMEOUT, SUCCESS.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Detailed description why the call has ended.
        /// </summary>
        public string Message { get; set; }
    }
}