using System;
using System.Runtime.Serialization;

namespace Sess5
{
    [Serializable]
    internal class VoterApplicationException : Exception
    {
        public VoterApplicationException()
        {
        }

        public VoterApplicationException(string message) : base(message)
        {
        }

        public VoterApplicationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VoterApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}