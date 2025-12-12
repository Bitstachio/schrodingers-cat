using System;

namespace Shared.Exceptions
{
    /// <summary>
    /// Exception thrown when a collider is expected to be a trigger but is not.
    /// </summary>
    public class ColliderNotTriggerException : Exception
    {
        public ColliderNotTriggerException() : base("`isTrigger` is required to be checked")
        {
        }

        public ColliderNotTriggerException(string message) : base(message)
        {
        }

        public ColliderNotTriggerException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}