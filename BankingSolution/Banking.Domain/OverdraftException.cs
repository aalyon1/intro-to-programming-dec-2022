using System.Runtime.Serialization;

namespace Banking.Domain
{
    [Serializable]
    internal class OverdraftException : Exception
    {
        public OverdraftException()
        {
        }

        public OverdraftException(string? message) : base(message)
        {
        }

        public OverdraftException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OverdraftException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}