using System;

namespace Features.Panel.StaticPanel.Exceptions
{
    public class ToggleLengthMismatchException : Exception
    {
        public ToggleLengthMismatchException(int togglesLength, int keyLength) : base(
            $"toggles length = {togglesLength}, key length = {keyLength}")
        {
        }

        public ToggleLengthMismatchException(string message) : base(message)
        {
        }

        public ToggleLengthMismatchException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}