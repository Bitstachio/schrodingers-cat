using System;

namespace Features.Panel.Common.Exceptions
{
    public class PanelAlreadyOpenException : Exception
    {
        public PanelAlreadyOpenException()
        {
        }

        public PanelAlreadyOpenException(string message)
            : base(message)
        {
        }

        public PanelAlreadyOpenException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}