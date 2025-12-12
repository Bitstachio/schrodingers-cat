using System;

namespace Shared.Exceptions
{
    public class TooManyComponentsException : Exception
    {
        public TooManyComponentsException(Type type, int maxAllowed, int actualCount)
            : base($"Found {actualCount} components of type {type.Name}, but maximum allowed is {maxAllowed}")
        {
        }
    }
}