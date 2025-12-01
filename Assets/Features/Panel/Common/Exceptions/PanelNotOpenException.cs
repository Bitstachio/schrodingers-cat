using System;

namespace Features.Panel.Common.Exceptions
{
    public class PanelNotOpenException : Exception
    {
        public PanelNotOpenException()
        {
        }

        public PanelNotOpenException(string message)
            : base(message)
        {
        }

        public PanelNotOpenException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}